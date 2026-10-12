using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI
{
    /// <summary>
    /// Diseño de la pestaña Consultar (lo comparten todas las pantallas CRUD):
    /// filas tipo tarjeta, código en azul, insignias, barra de cantidad, columna Acciones,
    /// filtros (chips), orden al hacer clic en el encabezado y paginación.
    ///
    /// Uso en un formulario:
    ///   consulta = new EstiloConsulta(dgvDatos, lblRegistros, pagConsulta);
    ///   consulta.Codigo("colCodigoSucursal", "SUC");
    ///   consulta.AgregarFiltro(chpTodos, "Todos", null, Color.Empty);
    ///   consulta.Actualizar();   // después de cargar o cambiar los datos
    ///
    /// Solo cambia cómo se ven y se recorren los datos; no consulta la base de datos.
    /// </summary>
    public class EstiloConsulta
    {
        #region Colores y fuentes de la tabla

        private static readonly Color FondoTabla = Tema.FondoTarjeta;
        private static readonly Color FondoEncabezado = Tema.FondoSecundario;
        private static readonly Color FondoFila = Tema.Mezclar(Tema.FondoTarjeta, Tema.FondoSecundario, 0.45f);
        private static readonly Color FondoFilaSeleccionada = Tema.Mezclar(FondoFila, Tema.Acento, 0.16f);
        private static readonly Color FondoInsignia = Tema.FondoPrincipal;

        private static readonly Font FuenteEncabezado = new Font("Segoe UI", 10F, FontStyle.Bold);
        private static readonly Font FuenteTexto = new Font("Segoe UI", 10F, FontStyle.Regular);
        private static readonly Font FuenteCodigo = new Font("Segoe UI Semibold", 10F, FontStyle.Regular);
        private static readonly Font FuenteInsignia = new Font("Segoe UI Semibold", 9F, FontStyle.Regular);
        private static readonly Font FuenteSubtitulo = new Font("Segoe UI", 8.25F, FontStyle.Regular);
        private static readonly Font FuenteAccion = new Font("Segoe UI", 9.5F, FontStyle.Regular);

        private const TextFormatFlags FormatoTexto = TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding;

        #endregion

        #region Configuración

        private enum TipoColumna { Codigo, Insignia, Estado, DosLineas, Barra, Moneda, Acciones }

        private class ConfigColumna
        {
            public TipoColumna Tipo;
            public string Prefijo;
            public IconChar Icono = IconChar.None;
            public string Formato = "{0}";
            public string ColumnaSecundaria;
            public string TextoActivo, TextoInactivo;
            public string Unidad;
            public string Columna;
            public Func<DataGridViewRow, Color> Color;
        }

        private class Filtro
        {
            public BotonRedondeado Chip;
            public string Texto;
            public Func<DataGridViewRow, bool> Condicion; // null = mostrar todos
            public Color Color;
        }

        private readonly DataGridView dgv;
        private readonly Label lblRegistros;
        private readonly Paginador paginador;
        private readonly Dictionary<string, ConfigColumna> columnas = new Dictionary<string, ConfigColumna>();
        private readonly List<Filtro> filtros = new List<Filtro>();
        private Filtro filtroActivo;

        private string columnaAcciones;
        private string columnaNotas;
        private Action accionEditar;

        private DataGridViewColumn columnaOrden;
        private bool ordenAscendente = true;
        private bool ordenando;

        private bool refrescando;
        private bool refrescoPendiente;
        private DateTime ultimaCarga = DateTime.Now;
        private TarjetaResumen tarjetaActualizacion;
        private readonly System.Windows.Forms.Timer reloj = new System.Windows.Forms.Timer { Interval = 30000 };

        public EstiloConsulta(DataGridView dgv, Label lblRegistros, Paginador paginador)
        {
            this.dgv = dgv;
            this.lblRegistros = lblRegistros;
            this.paginador = paginador;

            // La paginación reemplaza a la barra de desplazamiento.
            dgv.ScrollBars = ScrollBars.None;
            dgv.BackgroundColor = FondoTabla;
            foreach (DataGridViewColumn columna in dgv.Columns) columna.SortMode = DataGridViewColumnSortMode.Programmatic;

            dgv.CellPainting += Dgv_CellPainting;
            dgv.CellMouseClick += Dgv_CellMouseClick;
            dgv.CellMouseMove += Dgv_CellMouseMove;
            dgv.ColumnHeaderMouseClick += Dgv_ColumnHeaderMouseClick;
            dgv.SortCompare += Dgv_SortCompare;
            dgv.Resize += (s, e) => ProgramarRefresco();
            dgv.SelectionChanged += (s, e) => dgv.Invalidate();
            dgv.Disposed += (s, e) => reloj.Dispose();

            paginador.PaginaCambiada += (s, e) => ProgramarRefresco();
            reloj.Tick += (s, e) => MostrarUltimaActualizacion();
            reloj.Start();
        }

        /// <summary>Muestra el código con prefijo: 1 → #SUC-001 (el valor guardado no cambia).</summary>
        public void Codigo(string columna, string prefijo)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Codigo, Prefijo = prefijo };
        }

        /// <summary>
        /// Muestra el valor dentro de una píldora con ícono.
        /// formato: por ejemplo "Mínimo ({0})". color: null = gris; o un color según la fila.
        /// </summary>
        public void Insignia(string columna, IconChar icono, string formato = "{0}", Func<DataGridViewRow, Color> color = null)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Insignia, Icono = icono, Formato = formato, Color = color };
        }

        /// <summary>Estado activo (verde) o inactivo (rojo) con el texto indicado.</summary>
        public void Estado(string columna, string textoActivo, string textoInactivo)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Estado, TextoActivo = textoActivo, TextoInactivo = textoInactivo };
        }

        /// <summary>
        /// Ícono + texto principal + subtítulo gris debajo (tomado de otra columna).
        /// La columna del subtítulo se oculta porque ya se ve aquí. columnaSubtitulo puede ser null.
        /// </summary>
        public void DosLineas(string columna, string columnaSubtitulo, IconChar icono, string formatoSubtitulo = "{0}")
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.DosLineas, ColumnaSecundaria = columnaSubtitulo, Icono = icono, Formato = formatoSubtitulo };
            if (columnaSubtitulo != null) dgv.Columns[columnaSubtitulo].Visible = false;
        }

        /// <summary>
        /// Cantidad con barra de progreso. La barra se llena al llegar al triple de la cantidad mínima.
        /// color: color de la barra según la fila (por ejemplo, rojo si está en estado crítico).
        /// </summary>
        public void Barra(string columna, string columnaMinimo, string unidad, Func<DataGridViewRow, Color> color)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Barra, Columna = columna, ColumnaSecundaria = columnaMinimo, Unidad = unidad, Color = color };
        }

        /// <summary>Muestra el valor como dinero: Q 1,234.50</summary>
        public void Moneda(string columna)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Moneda };
        }

        /// <summary>
        /// Columna de acciones: ver detalle (ojo), Editar y Ver notas.
        /// columnaNotas: columna con las observaciones (se oculta y se ve con "Ver notas"); null = sin botón.
        /// </summary>
        public void Acciones(string columna, Action editar, string columnaNotas = null)
        {
            columnas[columna] = new ConfigColumna { Tipo = TipoColumna.Acciones };
            columnaAcciones = columna;
            accionEditar = editar;
            this.columnaNotas = columnaNotas;

            DataGridViewColumn col = dgv.Columns[columna];
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.MinimumWidth = columnaNotas != null ? 196 : 116;
            if (columnaNotas != null) dgv.Columns[columnaNotas].Visible = false;
        }

        /// <summary>
        /// Convierte un botón en un chip de filtro. condicion = qué filas se muestran (null = todas).
        /// El chip muestra cuántas filas cumplen la condición, por ejemplo "Inactivas (2)".
        /// </summary>
        public void AgregarFiltro(BotonRedondeado chip, string texto, Func<DataGridViewRow, bool> condicion, Color color)
        {
            Filtro filtro = new Filtro { Chip = chip, Texto = texto, Condicion = condicion, Color = color };
            filtros.Add(filtro);
            if (filtroActivo == null) filtroActivo = filtro;

            chip.Click += (s, e) =>
            {
                filtroActivo = filtro;
                paginador.PaginaActual = 1;
                ProgramarRefresco();
            };
            PintarChip(filtro);
        }

        /// <summary>Tarjeta donde se muestra "Hace X min" desde la última carga de datos.</summary>
        public TarjetaResumen TarjetaActualizacion
        {
            get { return tarjetaActualizacion; }
            set { tarjetaActualizacion = value; MostrarUltimaActualizacion(); }
        }

        #endregion

        #region Datos para las tarjetas y los filtros

        /// <summary>Cantidad total de registros cargados (sin importar el filtro).</summary>
        public int TotalRegistros { get { return dgv.Rows.Count; } }

        public int Contar(Func<DataGridViewRow, bool> condicion)
        {
            return dgv.Rows.Cast<DataGridViewRow>().Count(condicion);
        }

        public decimal Sumar(string columna)
        {
            return dgv.Rows.Cast<DataGridViewRow>().Sum(fila => Numero(fila, columna));
        }

        public static string Texto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return valor == null || valor == DBNull.Value ? string.Empty : Convert.ToString(valor);
        }

        public static decimal Numero(DataGridViewRow fila, string columna)
        {
            decimal numero;
            return decimal.TryParse(Texto(fila, columna), NumberStyles.Number, CultureInfo.CurrentCulture, out numero) ? numero : 0m;
        }

        public static DateTime Fecha(DataGridViewRow fila, string columna)
        {
            DateTime fecha;
            return DateTime.TryParse(Texto(fila, columna), out fecha) ? fecha : DateTime.MinValue;
        }

        public static bool EsActivo(DataGridViewRow fila, string columna)
        {
            return EsActivo(fila.Cells[columna].Value);
        }

        public static bool EsActivo(object valor)
        {
            if (valor is bool) return (bool)valor;
            string texto = Convert.ToString(valor).Trim().ToLowerInvariant();
            return texto == "true" || texto == "1" || texto == "activo" || texto == "activa" || texto == "a";
        }

        #endregion

        #region Filtro, paginación y contador

        /// <summary>Llamar cada vez que se cargan o cambian los datos de la tabla.</summary>
        public void Actualizar()
        {
            if (!ordenando)
            {
                ultimaCarga = DateTime.Now;
                columnaOrden = null; // datos nuevos: se pierde el orden anterior
            }
            MostrarUltimaActualizacion();
            ProgramarRefresco();
        }

        /// <summary>
        /// Agrupa varios cambios seguidos (por ejemplo, cada fila que se agrega)
        /// en un solo refresco que se ejecuta cuando el formulario termina lo que estaba haciendo.
        /// </summary>
        private void ProgramarRefresco()
        {
            if (!dgv.IsHandleCreated) { Refrescar(); return; }
            if (refrescoPendiente) return;
            refrescoPendiente = true;
            dgv.BeginInvoke((Action)(() => { refrescoPendiente = false; Refrescar(); }));
        }

        private void Refrescar()
        {
            if (refrescando) return;
            refrescando = true;
            try
            {
                foreach (Filtro filtro in filtros) PintarChip(filtro);
                AjustarColumnas();

                // 1) Filas que cumplen el filtro elegido
                List<DataGridViewRow> filtradas = dgv.Rows.Cast<DataGridViewRow>()
                    .Where(fila => filtroActivo == null || filtroActivo.Condicion == null || filtroActivo.Condicion(fila))
                    .ToList();

                // 2) Filas de la página actual
                int porPagina = FilasPorPagina();
                paginador.TotalPaginas = (int)Math.Ceiling(filtradas.Count / (double)porPagina);
                List<DataGridViewRow> pagina = filtradas.Skip((paginador.PaginaActual - 1) * porPagina).Take(porPagina).ToList();
                HashSet<DataGridViewRow> enPagina = new HashSet<DataGridViewRow>(pagina);

                // 3) Mostrar solo esas filas. Primero se muestran las de la página y se selecciona una,
                //    porque Windows Forms no permite ocultar la fila seleccionada.
                foreach (DataGridViewRow fila in pagina) if (!fila.Visible) fila.Visible = true;

                int primeraColumna = PrimeraColumnaVisible();
                if (pagina.Count > 0 && primeraColumna >= 0 && (dgv.CurrentRow == null || !enPagina.Contains(dgv.CurrentRow)))
                    dgv.CurrentCell = pagina[0].Cells[primeraColumna];

                CurrencyManager enlace = null;
                if (pagina.Count == 0)
                {
                    // Ninguna fila cumple el filtro: se quita la selección y, si la tabla
                    // está enlazada a una lista, se suspende el enlace para poder ocultarlas todas.
                    dgv.CurrentCell = null;
                    if (dgv.DataSource != null)
                    {
                        enlace = (CurrencyManager)dgv.BindingContext[dgv.DataSource, dgv.DataMember];
                        enlace.SuspendBinding();
                    }
                }

                foreach (DataGridViewRow fila in dgv.Rows)
                    if (!enPagina.Contains(fila) && fila.Visible) fila.Visible = false;

                if (enlace != null) enlace.ResumeBinding();
                if (pagina.Count == 0) dgv.ClearSelection();

                lblRegistros.Text = filtradas.Count == 1 ? "1 registro encontrado" : filtradas.Count.ToString("N0") + " registros encontrados";
                dgv.Invalidate();
            }
            finally
            {
                refrescando = false;
            }
        }

        /// <summary>
        /// Reparte el ancho de la tabla según lo que necesita cada columna (encabezado,
        /// insignias, barras...). Si no alcanza el espacio, las columnas de texto se recortan con "...".
        /// </summary>
        private void AjustarColumnas()
        {
            List<DataGridViewRow> muestra = dgv.Rows.Cast<DataGridViewRow>().Take(200).ToList();
            List<DataGridViewColumn> visibles = dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).ToList();
            Dictionary<DataGridViewColumn, int> anchos = new Dictionary<DataGridViewColumn, int>();
            Dictionary<DataGridViewColumn, int> minimos = new Dictionary<DataGridViewColumn, int>();
            List<DataGridViewColumn> achicables = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn columna in visibles)
            {
                ConfigColumna config;
                columnas.TryGetValue(columna.Name, out config);
                int ancho = AnchoNecesario(columna, config, muestra);
                anchos[columna] = ancho;

                if (config != null && (config.Tipo == TipoColumna.Codigo || config.Tipo == TipoColumna.Estado || config.Tipo == TipoColumna.Acciones))
                {
                    minimos[columna] = ancho; // nunca se recortan
                    continue;
                }
                // Ancho deseado (con tope para que una columna muy larga no ocupe todo).
                int tope = config == null ? 140 : config.Tipo == TipoColumna.DosLineas ? 190 : 160;
                minimos[columna] = Math.Min(ancho, tope);
                achicables.Add(columna);
            }

            // Si no alcanza el ancho, todas las columnas achicables se reducen en la misma proporción
            // (sin bajar de 60 px); lo que no cabe se recorta con "...".
            int fijas = visibles.Where(c => !achicables.Contains(c)).Sum(c => minimos[c]);
            int deseado = achicables.Sum(c => minimos[c]);
            double factor = deseado == 0 ? 1 : Math.Min(1.0, Math.Max(0, dgv.ClientSize.Width - fijas - 2) / (double)deseado);
            foreach (DataGridViewColumn columna in achicables)
                minimos[columna] = Math.Max(Math.Min(60, minimos[columna]), (int)(minimos[columna] * factor));

            foreach (DataGridViewColumn columna in visibles)
            {
                columna.MinimumWidth = minimos[columna];
                columna.FillWeight = anchos[columna];
            }
        }

        private int AnchoNecesario(DataGridViewColumn columna, ConfigColumna config, List<DataGridViewRow> filas)
        {
            if (config != null && config.Tipo == TipoColumna.Acciones) return columnaNotas != null ? 196 : 116;

            bool ordenable = columna.SortMode != DataGridViewColumnSortMode.NotSortable;
            int ancho = Medir(columna.HeaderText, FuenteEncabezado) + (ordenable ? 26 : 0);
            foreach (DataGridViewRow fila in filas) ancho = Math.Max(ancho, AnchoContenido(columna, config, fila));
            return Math.Min(ancho, 340) + 20; // 20 = márgenes de la celda
        }

        private int AnchoContenido(DataGridViewColumn columna, ConfigColumna config, DataGridViewRow fila)
        {
            DataGridViewCell celda = fila.Cells[columna.Index];
            string texto = Convert.ToString(celda.FormattedValue);
            if (config == null) return Medir(texto, FuenteTexto);

            switch (config.Tipo)
            {
                case TipoColumna.Codigo:
                    return Medir(TextoCodigo(config, celda.Value), FuenteCodigo);
                case TipoColumna.Insignia:
                    return texto.Length == 0 ? 0 : Medir(string.Format(config.Formato, texto), FuenteInsignia) + (config.Icono == IconChar.None ? 0 : 20) + 22;
                case TipoColumna.Estado:
                    return Math.Max(Medir(config.TextoActivo, FuenteInsignia), Medir(config.TextoInactivo, FuenteInsignia)) + 42;
                case TipoColumna.DosLineas:
                    string subtitulo = config.ColumnaSecundaria == null ? string.Empty : string.Format(config.Formato, Texto(fila, config.ColumnaSecundaria));
                    return 38 + Math.Max(Medir(texto, FuenteTexto), Medir(subtitulo, FuenteSubtitulo));
                case TipoColumna.Barra:
                    return Medir(Numero(fila, config.Columna).ToString("N0") + " " + config.Unidad, FuenteCodigo) + 68;
                case TipoColumna.Moneda:
                    return Medir(TextoMoneda(celda.Value), FuenteTexto);
                default:
                    return Medir(texto, FuenteTexto);
            }
        }

        private static int Medir(string texto, Font fuente)
        {
            return string.IsNullOrEmpty(texto) ? 0 : TextRenderer.MeasureText(texto, fuente, Size.Empty, TextFormatFlags.NoPadding).Width;
        }

        private int FilasPorPagina()
        {
            int alto = dgv.ClientSize.Height - dgv.ColumnHeadersHeight;
            return Math.Max(1, alto / Math.Max(1, dgv.RowTemplate.Height));
        }

        private int PrimeraColumnaVisible()
        {
            DataGridViewColumn columna = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            return columna == null ? -1 : columna.Index;
        }

        private void MostrarUltimaActualizacion()
        {
            if (tarjetaActualizacion == null) return;
            TimeSpan tiempo = DateTime.Now - ultimaCarga;
            if (tiempo.TotalMinutes < 1) tarjetaActualizacion.Valor = "Hace un momento";
            else if (tiempo.TotalMinutes < 60) tarjetaActualizacion.Valor = "Hace " + (int)tiempo.TotalMinutes + " min";
            else tarjetaActualizacion.Valor = "Hoy " + ultimaCarga.ToString("HH:mm");
        }

        private void PintarChip(Filtro filtro)
        {
            BotonRedondeado chip = filtro.Chip;
            string texto = filtro.Condicion == null ? filtro.Texto : filtro.Texto + " (" + Contar(filtro.Condicion) + ")";
            bool seleccionado = filtro == filtroActivo;
            bool neutro = filtro.Color == Color.Empty;

            Color fondo, letra;
            if (neutro)
            {
                fondo = seleccionado ? Tema.Mezclar(Tema.FondoSecundario, Color.White, 0.16f) : Tema.FondoSecundario;
                letra = seleccionado ? Color.White : Tema.TextoSecundario;
            }
            else
            {
                fondo = Tema.Mezclar(Tema.FondoSecundario, filtro.Color, seleccionado ? 0.55f : 0.22f);
                letra = seleccionado ? Color.White : Tema.Aclarar(filtro.Color, 0.45f);
            }

            chip.Text = texto;
            chip.Width = TextRenderer.MeasureText(texto, chip.Font).Width + 28;
            chip.BackColor = fondo;
            chip.ForeColor = letra;
            chip.IconColor = letra;
            chip.ColorHover = Tema.Aclarar(fondo, 0.08f);
        }

        #endregion

        #region Orden por columna

        private void Dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn columna = dgv.Columns[e.ColumnIndex];
            if (columna.SortMode == DataGridViewColumnSortMode.NotSortable) return;

            ordenAscendente = columna == columnaOrden ? !ordenAscendente : true;
            ordenando = true;
            try
            {
                IList lista = dgv.DataSource as IList;
                if (lista != null && !string.IsNullOrEmpty(columna.DataPropertyName))
                {
                    // Tabla enlazada a una lista (List<Sucursal>, etc.): se ordena la lista.
                    PropertyDescriptor propiedad = ListBindingHelper.GetListItemProperties(lista)[columna.DataPropertyName];
                    if (propiedad == null) return;
                    IEnumerable<object> ordenados = ordenAscendente
                        ? lista.Cast<object>().OrderBy(item => propiedad.GetValue(item), Comparer<object>.Default)
                        : lista.Cast<object>().OrderByDescending(item => propiedad.GetValue(item), Comparer<object>.Default);
                    IList nueva = (IList)Activator.CreateInstance(lista.GetType());
                    foreach (object item in ordenados.ToList()) nueva.Add(item);
                    dgv.DataSource = nueva;
                }
                else if (dgv.DataSource == null)
                {
                    // Filas agregadas a mano: el DataGridView las ordena (ver Dgv_SortCompare).
                    dgv.Sort(columna, ordenAscendente ? ListSortDirection.Ascending : ListSortDirection.Descending);
                }
                columnaOrden = columna;
            }
            finally
            {
                ordenando = false;
            }
            paginador.PaginaActual = 1;
            ProgramarRefresco();
        }

        /// <summary>Ordena números y fechas por su valor (no como texto).</summary>
        private void Dgv_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            string a = Convert.ToString(e.CellValue1), b = Convert.ToString(e.CellValue2);
            decimal n1, n2;
            DateTime f1, f2;
            if (decimal.TryParse(a, out n1) && decimal.TryParse(b, out n2)) e.SortResult = n1.CompareTo(n2);
            else if (DateTime.TryParse(a, out f1) && DateTime.TryParse(b, out f2)) e.SortResult = f1.CompareTo(f2);
            else e.SortResult = string.Compare(a, b, StringComparison.CurrentCultureIgnoreCase);
            e.Handled = true;
        }

        #endregion

        #region Dibujo de la tabla

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            DataGridViewColumn columna = dgv.Columns[e.ColumnIndex];

            if (e.RowIndex == -1)
            {
                PintarEncabezado(g, e.CellBounds, columna);
                e.Handled = true;
                return;
            }

            DataGridViewRow fila = dgv.Rows[e.RowIndex];
            PintarFondoFila(g, e.CellBounds, fila.Selected);

            ConfigColumna config;
            columnas.TryGetValue(columna.Name, out config);
            Rectangle area = new Rectangle(e.CellBounds.X + 12, e.CellBounds.Y, e.CellBounds.Width - 16, e.CellBounds.Height);

            if (config == null)
            {
                TextRenderer.DrawText(g, Convert.ToString(e.FormattedValue), FuenteTexto, area, Tema.Texto, FormatoTexto);
            }
            else
            {
                switch (config.Tipo)
                {
                    case TipoColumna.Codigo:
                        TextRenderer.DrawText(g, TextoCodigo(config, e.Value), FuenteCodigo, area, Tema.Acento, FormatoTexto);
                        break;
                    case TipoColumna.Insignia:
                        string texto = Convert.ToString(e.FormattedValue);
                        if (texto.Length > 0)
                            PintarInsignia(g, area, string.Format(config.Formato, texto), config.Icono, config.Color == null ? Color.Empty : config.Color(fila));
                        break;
                    case TipoColumna.Estado:
                        bool activo = EsActivo(e.Value);
                        PintarInsignia(g, area, activo ? config.TextoActivo : config.TextoInactivo,
                            activo ? IconChar.CircleCheck : IconChar.CircleXmark, activo ? Tema.Exito : Tema.Peligro);
                        break;
                    case TipoColumna.DosLineas:
                        PintarDosLineas(g, area, config, fila, Convert.ToString(e.FormattedValue));
                        break;
                    case TipoColumna.Barra:
                        PintarBarra(g, area, config, fila);
                        break;
                    case TipoColumna.Moneda:
                        TextRenderer.DrawText(g, TextoMoneda(e.Value), FuenteTexto, area, Tema.Texto, FormatoTexto);
                        break;
                    case TipoColumna.Acciones:
                        PintarAcciones(g, e.CellBounds);
                        break;
                }
            }
            e.Handled = true;
        }

        private void PintarEncabezado(Graphics g, Rectangle celda, DataGridViewColumn columna)
        {
            using (SolidBrush fondo = new SolidBrush(FondoTabla)) g.FillRectangle(fondo, celda);

            // Banda del encabezado redondeada: cada celda dibuja su parte de la misma banda.
            Rectangle banda = new Rectangle(-dgv.HorizontalScrollingOffset, celda.Y + 2, AnchoVisible(), celda.Height - 6);
            g.SetClip(celda);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(banda, 8))
            using (SolidBrush relleno = new SolidBrush(FondoEncabezado))
            {
                g.FillPath(relleno, ruta);
            }
            g.ResetClip();

            bool ordenable = columna.SortMode != DataGridViewColumnSortMode.NotSortable;
            Rectangle area = new Rectangle(celda.X + 12, celda.Y + 2, celda.Width - 16 - (ordenable ? 18 : 0), celda.Height - 6);
            TextRenderer.DrawText(g, columna.HeaderText, FuenteEncabezado, area, Tema.Texto, FormatoTexto);

            if (ordenable)
            {
                // La flecha va después del título; el título deja libre su espacio para no encimarse.
                IconChar flecha = columna != columnaOrden ? IconChar.Sort : (ordenAscendente ? IconChar.SortUp : IconChar.SortDown);
                Color color = columna == columnaOrden ? Tema.Acento : Tema.TextoDeshabilitado;
                Bitmap imagen = Tema.Icono(flecha, color, 16);
                int x = Math.Min(area.X + Medir(columna.HeaderText, FuenteEncabezado) + 4, area.Right + 2);
                g.DrawImage(imagen, x, area.Y + (area.Height - imagen.Height) / 2);
            }
        }

        private void PintarFondoFila(Graphics g, Rectangle celda, bool seleccionada)
        {
            using (SolidBrush fondo = new SolidBrush(FondoTabla)) g.FillRectangle(fondo, celda);

            // Tarjeta de la fila (con separación arriba y abajo). Cada celda dibuja su parte.
            Rectangle tarjeta = new Rectangle(-dgv.HorizontalScrollingOffset + 1, celda.Y + 3, AnchoVisible() - 3, celda.Height - 6);
            g.SetClip(celda);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(tarjeta, 8))
            using (SolidBrush relleno = new SolidBrush(seleccionada ? FondoFilaSeleccionada : FondoFila))
            using (Pen borde = new Pen(seleccionada ? Tema.Acento : Tema.Borde, 1f))
            {
                g.FillPath(relleno, ruta);
                g.DrawPath(borde, ruta);
            }
            g.ResetClip();
        }

        private int AnchoVisible()
        {
            return dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
        }

        /// <summary>Píldora con ícono. color vacío = gris neutro.</summary>
        private static void PintarInsignia(Graphics g, Rectangle area, string texto, IconChar icono, Color color)
        {
            bool neutro = color == Color.Empty;
            Color fondo = neutro ? FondoInsignia : Tema.Mezclar(FondoFila, color, 0.22f);
            Color borde = neutro ? Tema.Borde : Tema.Mezclar(FondoFila, color, 0.55f);
            Color letra = neutro ? Tema.Texto : Tema.Aclarar(color, 0.40f);
            Color colorIcono = neutro ? Tema.TextoSecundario : letra;

            int anchoIcono = icono == IconChar.None ? 0 : 20;
            int anchoTexto = TextRenderer.MeasureText(g, texto, FuenteInsignia, Size.Empty, TextFormatFlags.NoPadding).Width;
            int ancho = Math.Min(area.Width - 4, anchoTexto + anchoIcono + 20);
            Rectangle pildora = new Rectangle(area.X - 2, area.Y + (area.Height - 24) / 2, ancho, 24);

            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(pildora, 12))
            using (SolidBrush relleno = new SolidBrush(fondo))
            using (Pen pluma = new Pen(borde, 1f))
            {
                g.FillPath(relleno, ruta);
                g.DrawPath(pluma, ruta);
            }

            int x = pildora.X + 10;
            if (anchoIcono > 0)
            {
                Bitmap imagen = Tema.Icono(icono, colorIcono, 17);
                g.DrawImage(imagen, x, pildora.Y + (pildora.Height - imagen.Height) / 2);
                x += anchoIcono;
            }
            Rectangle rectTexto = new Rectangle(x, pildora.Y, pildora.Right - x - 8, pildora.Height);
            TextRenderer.DrawText(g, texto, FuenteInsignia, rectTexto, letra, FormatoTexto);
        }

        private void PintarDosLineas(Graphics g, Rectangle area, ConfigColumna config, DataGridViewRow fila, string principal)
        {
            Rectangle cuadro = new Rectangle(area.X - 2, area.Y + (area.Height - 28) / 2, 28, 28);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(cuadro, 8))
            using (SolidBrush relleno = new SolidBrush(FondoInsignia))
            using (Pen pluma = new Pen(Tema.Borde, 1f))
            {
                g.FillPath(relleno, ruta);
                g.DrawPath(pluma, ruta);
            }
            Bitmap imagen = Tema.Icono(config.Icono, Tema.Acento, 20);
            g.DrawImage(imagen, cuadro.X + (cuadro.Width - imagen.Width) / 2, cuadro.Y + (cuadro.Height - imagen.Height) / 2);

            int x = cuadro.Right + 10;
            string subtitulo = config.ColumnaSecundaria == null ? string.Empty : Texto(fila, config.ColumnaSecundaria);
            if (subtitulo.Length == 0)
            {
                TextRenderer.DrawText(g, principal, FuenteTexto, new Rectangle(x, area.Y, area.Right - x, area.Height), Tema.Texto, FormatoTexto);
                return;
            }
            int centro = area.Y + area.Height / 2;
            TextRenderer.DrawText(g, principal, FuenteTexto, new Rectangle(x, centro - 17, area.Right - x, 18), Tema.Texto, FormatoTexto);
            TextRenderer.DrawText(g, string.Format(config.Formato, subtitulo), FuenteSubtitulo, new Rectangle(x, centro + 1, area.Right - x, 15), Tema.TextoSecundario, FormatoTexto);
        }

        private void PintarBarra(Graphics g, Rectangle area, ConfigColumna config, DataGridViewRow fila)
        {
            decimal cantidad = Numero(fila, config.Columna);
            decimal minimo = Numero(fila, config.ColumnaSecundaria);
            string texto = cantidad.ToString("N0") + " " + config.Unidad;

            int anchoTexto = TextRenderer.MeasureText(g, texto, FuenteCodigo, Size.Empty, TextFormatFlags.NoPadding).Width;
            TextRenderer.DrawText(g, texto, FuenteCodigo, area, Tema.Texto, FormatoTexto);

            int anchoBarra = Math.Min(60, area.Width - anchoTexto - 12);
            if (anchoBarra < 20) return;
            Rectangle barra = new Rectangle(area.X + anchoTexto + 8, area.Y + (area.Height - 6) / 2, anchoBarra, 6);
            float porcentaje = minimo <= 0 ? 1f : (float)Math.Min(1m, cantidad / (minimo * 3));

            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(barra, 3))
            using (SolidBrush fondo = new SolidBrush(FondoInsignia))
            {
                g.FillPath(fondo, ruta);
            }
            if (porcentaje > 0)
            {
                Rectangle lleno = new Rectangle(barra.X, barra.Y, Math.Max(6, (int)(barra.Width * porcentaje)), barra.Height);
                using (GraphicsPath ruta = Tema.CrearRutaRedondeada(lleno, 3))
                using (SolidBrush relleno = new SolidBrush(config.Color == null ? Tema.Acento : config.Color(fila)))
                {
                    g.FillPath(relleno, ruta);
                }
            }
        }

        private string TextoCodigo(ConfigColumna config, object valor)
        {
            string texto = Convert.ToString(valor);
            return texto.Length == 0 ? string.Empty : "#" + config.Prefijo + "-" + texto.PadLeft(3, '0');
        }

        private static string TextoMoneda(object valor)
        {
            decimal numero;
            if (valor is decimal) numero = (decimal)valor;
            else if (!decimal.TryParse(Convert.ToString(valor), NumberStyles.Number, CultureInfo.CurrentCulture, out numero)) return Convert.ToString(valor);
            return "Q " + numero.ToString("N2");
        }

        #endregion

        #region Columna Acciones

        /// <summary>Zonas de la celda Acciones (relativas a la celda): ver, editar y notas.</summary>
        private Rectangle[] ZonasAcciones(Size celda)
        {
            int y = (celda.Height - 26) / 2;
            Rectangle ver = new Rectangle(8, y, 26, 26);
            Rectangle editar = new Rectangle(ver.Right + 4, y, 64, 26);
            Rectangle notas = columnaNotas == null ? Rectangle.Empty : new Rectangle(editar.Right + 4, y, 78, 26);
            return new[] { ver, editar, notas };
        }

        private void PintarAcciones(Graphics g, Rectangle celda)
        {
            Rectangle[] zonas = ZonasAcciones(celda.Size);
            for (int i = 0; i < zonas.Length; i++) zonas[i].Offset(celda.Location);

            Bitmap ojo = Tema.Icono(IconChar.Eye, Tema.TextoSecundario, 21);
            g.DrawImage(ojo, zonas[0].X + (zonas[0].Width - ojo.Width) / 2, zonas[0].Y + (zonas[0].Height - ojo.Height) / 2);

            Bitmap lapiz = Tema.Icono(IconChar.Pen, Tema.TextoSecundario, 17);
            g.DrawImage(lapiz, zonas[1].X + 4, zonas[1].Y + (zonas[1].Height - lapiz.Height) / 2);
            TextRenderer.DrawText(g, "Editar", FuenteAccion, new Rectangle(zonas[1].X + 22, zonas[1].Y, zonas[1].Width - 22, zonas[1].Height), Tema.TextoSecundario, FormatoTexto);

            if (columnaNotas != null)
            {
                using (GraphicsPath ruta = Tema.CrearRutaRedondeada(zonas[2], 6))
                using (SolidBrush relleno = new SolidBrush(Tema.FondoSecundario))
                using (Pen pluma = new Pen(Tema.Borde, 1f))
                {
                    g.FillPath(relleno, ruta);
                    g.DrawPath(pluma, ruta);
                }
                TextRenderer.DrawText(g, "Ver notas", FuenteAccion, zonas[2], Tema.Texto,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
        }

        private int AccionEn(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || columnaAcciones == null || dgv.Columns[e.ColumnIndex].Name != columnaAcciones) return -1;
            Rectangle[] zonas = ZonasAcciones(dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Size);
            for (int i = 0; i < zonas.Length; i++)
                if (zonas[i].Contains(e.Location)) return i;
            return -1;
        }

        private void Dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv.Cursor = AccionEn(e) >= 0 ? Cursors.Hand : Cursors.Default;
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int accion = AccionEn(e);
            if (accion < 0) return;
            DataGridViewRow fila = dgv.Rows[e.RowIndex];

            if (accion == 0) MostrarDetalle(fila);
            else if (accion == 1) { if (accionEditar != null) accionEditar(); }
            else MostrarNotas(fila);
        }

        /// <summary>Muestra todos los datos de la fila (también los de columnas ocultas).</summary>
        private void MostrarDetalle(DataGridViewRow fila)
        {
            StringBuilder texto = new StringBuilder();
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                if (columna.Name == columnaAcciones) continue;
                texto.AppendLine(columna.HeaderText + ": " + TextoParaMostrar(fila, columna));
            }
            MessageBox.Show(texto.ToString(), "Detalle del registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarNotas(DataGridViewRow fila)
        {
            string notas = Texto(fila, columnaNotas);
            MessageBox.Show(notas.Length > 0 ? notas : "Este registro no tiene notas.", dgv.Columns[columnaNotas].HeaderText,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string TextoParaMostrar(DataGridViewRow fila, DataGridViewColumn columna)
        {
            DataGridViewCell celda = fila.Cells[columna.Index];
            ConfigColumna config;
            if (!columnas.TryGetValue(columna.Name, out config)) return Convert.ToString(celda.FormattedValue);

            switch (config.Tipo)
            {
                case TipoColumna.Codigo: return TextoCodigo(config, celda.Value);
                case TipoColumna.Estado: return EsActivo(celda.Value) ? config.TextoActivo : config.TextoInactivo;
                case TipoColumna.Moneda: return TextoMoneda(celda.Value);
                default: return Convert.ToString(celda.FormattedValue);
            }
        }

        #endregion
    }
}
