using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI
{
    /// <summary>
    /// Tema visual "Vidrio oscuro" del sistema: fondo negro con resplandores violeta, turquesa y rosa,
    /// y tarjetas semitransparentes (vidrio) con esquinas redondeadas.
    /// Centraliza la paleta de colores, las fuentes y los métodos de dibujo
    /// (GraphicsPath) que usan todos los formularios de la Capa Presentación.
    /// </summary>
    public static class Tema
    {
        #region Paleta de colores

        // Fondos sólidos: los usan los controles que no pueden ser transparentes (cajas de texto, listas, tablas).
        public static readonly Color FondoPrincipal = ColorTranslator.FromHtml("#0C0A1A");
        public static readonly Color FondoSecundario = ColorTranslator.FromHtml("#1C1834");
        public static readonly Color FondoMenu = ColorTranslator.FromHtml("#120F24");
        public static readonly Color FondoTarjeta = ColorTranslator.FromHtml("#15122B");
        public static readonly Color FilaAlterna = ColorTranslator.FromHtml("#191530");
        public static readonly Color Borde = ColorTranslator.FromHtml("#332D57");
        public static readonly Color BordeSuave = ColorTranslator.FromHtml("#262043");
        public static readonly Color Seleccion = ColorTranslator.FromHtml("#3A2C7A");

        public static readonly Color Texto = ColorTranslator.FromHtml("#F4F2FF");
        public static readonly Color TextoSecundario = ColorTranslator.FromHtml("#A6A1C4");
        public static readonly Color TextoDeshabilitado = ColorTranslator.FromHtml("#6C6790");

        public static readonly Color Acento = ColorTranslator.FromHtml("#8B5CF6");       // violeta
        public static readonly Color AcentoFin = ColorTranslator.FromHtml("#3B82F6");    // azul (fin del degradado)
        public static readonly Color Exito = ColorTranslator.FromHtml("#10B981");
        public static readonly Color Peligro = ColorTranslator.FromHtml("#F43F5E");
        public static readonly Color Advertencia = ColorTranslator.FromHtml("#F59E0B");
        public static readonly Color Neutro = ColorTranslator.FromHtml("#332D57");

        public static readonly Color Lila = ColorTranslator.FromHtml("#A78BFA");
        public static readonly Color Celeste = ColorTranslator.FromHtml("#22D3EE");
        public static readonly Color Rosa = ColorTranslator.FromHtml("#EC4899");
        public static readonly Color Naranja = ColorTranslator.FromHtml("#F97316");

        // Vidrio: blanco con poca opacidad, se dibuja encima del fondo degradado.
        public static readonly Color Vidrio = Color.FromArgb(16, 255, 255, 255);
        public static readonly Color VidrioClaro = Color.FromArgb(30, 255, 255, 255);
        public static readonly Color BordeVidrio = Color.FromArgb(30, 255, 255, 255);

        // Resplandores del fondo (arriba a la izquierda, a la derecha y abajo).
        public static readonly Color ResplandorVioleta = ColorTranslator.FromHtml("#6D28D9");
        public static readonly Color ResplandorTurquesa = ColorTranslator.FromHtml("#0E7490");
        public static readonly Color ResplandorRosa = ColorTranslator.FromHtml("#9D174D");

        /// <summary>
        /// Color final del degradado de los botones de la paleta (Acento, Éxito, Peligro, Advertencia).
        /// Para cualquier otro color devuelve Color.Empty (sin degradado).
        /// </summary>
        public static Color ColorFinDegradado(Color inicio)
        {
            int argb = inicio.ToArgb();
            if (argb == Acento.ToArgb()) return AcentoFin;
            if (argb == Exito.ToArgb()) return ColorTranslator.FromHtml("#059669");
            if (argb == Peligro.ToArgb()) return ColorTranslator.FromHtml("#E11D48");
            if (argb == Advertencia.ToArgb()) return Naranja;
            return Color.Empty;
        }

        #endregion

        #region Tipografía (Segoe UI)

        public static readonly Font FuenteNormal = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font FuenteLectura = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font FuenteNegrita = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font FuenteSubtitulo = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font FuenteTitulo = new Font("Segoe UI", 18F, FontStyle.Bold);

        #endregion

        #region Íconos (FontAwesome)

        private static readonly Dictionary<string, Bitmap> iconosGuardados = new Dictionary<string, Bitmap>();

        /// <summary>
        /// Devuelve un ícono de FontAwesome como imagen para dibujarlo con Graphics.DrawImage.
        /// Las imágenes se guardan para no volver a crearlas en cada repintado.
        /// </summary>
        public static Bitmap Icono(IconChar icono, Color color, int tamano)
        {
            string clave = icono + "|" + color.ToArgb() + "|" + tamano;
            Bitmap imagen;
            if (!iconosGuardados.TryGetValue(clave, out imagen))
            {
                imagen = icono.ToBitmap(IconFont.Auto, tamano, color, 0, FlipOrientation.Normal);
                iconosGuardados[clave] = imagen;
            }
            return imagen;
        }

        #endregion

        #region GraphicsPath: bordes redondeados

        /// <summary>Crea una ruta con esquinas redondeadas (base de todo el diseño "smooth").</summary>
        public static GraphicsPath CrearRutaRedondeada(RectangleF rect, float radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            if (radio <= 0.5f || rect.Width <= 1 || rect.Height <= 1)
            {
                ruta.AddRectangle(rect);
                return ruta;
            }

            float diametro = Math.Min(radio * 2f, Math.Min(rect.Width, rect.Height));
            RectangleF arco = new RectangleF(rect.Location, new SizeF(diametro, diametro));

            ruta.AddArc(arco, 180, 90);                       // superior izquierda
            arco.X = rect.Right - diametro;
            ruta.AddArc(arco, 270, 90);                       // superior derecha
            arco.Y = rect.Bottom - diametro;
            ruta.AddArc(arco, 0, 90);                         // inferior derecha
            arco.X = rect.Left;
            ruta.AddArc(arco, 90, 90);                        // inferior izquierda
            ruta.CloseFigure();
            return ruta;
        }

        public static GraphicsPath CrearRutaRedondeada(Rectangle rect, int radio)
        {
            return CrearRutaRedondeada((RectangleF)rect, (float)radio);
        }

        /// <summary>
        /// Rellena una ruta con un color o con un degradado diagonal (si colorFin no es Empty).
        /// </summary>
        public static void RellenarRuta(Graphics g, GraphicsPath ruta, Color colorInicio, Color colorFin)
        {
            RectangleF limites = ruta.GetBounds();
            if (colorFin == Color.Empty || limites.Width < 1 || limites.Height < 1)
            {
                using (SolidBrush pincel = new SolidBrush(colorInicio)) g.FillPath(pincel, ruta);
                return;
            }
            using (LinearGradientBrush pincel = new LinearGradientBrush(limites, colorInicio, colorFin, LinearGradientMode.ForwardDiagonal))
            {
                g.FillPath(pincel, ruta);
            }
        }

        /// <summary>Configura el Graphics para dibujar con suavizado (antialias).</summary>
        public static void ConfigurarCalidad(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Mezcla normal de colores semitransparentes. (HighQuality usa corrección gamma
            // y hace que el vidrio blanco se vea gris claro en lugar de casi transparente.)
            g.CompositingQuality = CompositingQuality.AssumeLinear;
        }

        /// <summary>
        /// Devuelve el primer color de fondo opaco subiendo por los contenedores.
        /// Se usa para mezclar colores (por ejemplo, el aspecto "deshabilitado").
        /// </summary>
        public static Color ObtenerColorFondo(Control control)
        {
            Control actual = control;
            while (actual != null)
            {
                PanelRedondeado tarjeta = actual as PanelRedondeado;
                if (tarjeta != null && tarjeta.ColorRelleno.A == 255) return tarjeta.ColorRelleno;
                if (actual.BackColor.A == 255) return actual.BackColor;
                actual = actual.Parent;
            }
            return FondoPrincipal;
        }

        /// <summary>Aclara un color (factor 0..1).</summary>
        public static Color Aclarar(Color color, float factor)
        {
            return Color.FromArgb(color.A,
                (int)(color.R + (255 - color.R) * factor),
                (int)(color.G + (255 - color.G) * factor),
                (int)(color.B + (255 - color.B) * factor));
        }

        /// <summary>Oscurece un color (factor 0..1).</summary>
        public static Color Oscurecer(Color color, float factor)
        {
            return Color.FromArgb(color.A,
                (int)(color.R * (1 - factor)),
                (int)(color.G * (1 - factor)),
                (int)(color.B * (1 - factor)));
        }

        /// <summary>Mezcla dos colores (0 = color1, 1 = color2).</summary>
        public static Color Mezclar(Color color1, Color color2, float cantidad)
        {
            return Color.FromArgb(
                (int)(color1.R + (color2.R - color1.R) * cantidad),
                (int)(color1.G + (color2.G - color1.G) * cantidad),
                (int)(color1.B + (color2.B - color1.B) * cantidad));
        }

        /// <summary>El mismo color con otra opacidad (0 = invisible, 255 = sólido).</summary>
        public static Color ConOpacidad(Color color, int opacidad)
        {
            return Color.FromArgb(Math.Max(0, Math.Min(255, opacidad)), color.R, color.G, color.B);
        }

        #endregion

        #region Fondo degradado y vidrio

        // Degradado ya dibujado para cada tamaño de ventana (se crea una sola vez por tamaño).
        private static readonly Dictionary<Size, Bitmap> degradadosGuardados = new Dictionary<Size, Bitmap>();

        /// <summary>
        /// Prepara un formulario para el diseño de vidrio. Se llama una vez, después de InitializeComponent:
        /// el formulario y sus pestañas dibujan el fondo degradado, y los paneles y etiquetas que tienen
        /// el color de fondo del tema se vuelven transparentes para que se vea el degradado o el vidrio.
        /// </summary>
        public static void AplicarFondo(Control raiz)
        {
            if (raiz == null) return;
            UsarDegradado(raiz);
            PrepararHijos(raiz);
        }

        private static void PrepararHijos(Control padre)
        {
            foreach (Control control in padre.Controls)
            {
                if (control is Form) continue;                      // un formulario hijo se prepara por separado

                if (control is TabPage) UsarDegradado(control);
                else if (PuedeSerTransparente(control) && EsColorDeFondo(control.BackColor)) control.BackColor = Color.Transparent;

                if (control is Panel || control is TabControl || control is DataGridView) ActivarDobleBuffer(control);
                if (control.HasChildren && !(control is TextBoxOscuro)) PrepararHijos(control);
            }
        }

        private static bool PuedeSerTransparente(Control control)
        {
            return (control is Label || control is Panel || control is PictureBox) && !(control is PanelRedondeado);
        }

        private static bool EsColorDeFondo(Color color)
        {
            int argb = color.ToArgb();
            return color.A == 255 && (argb == FondoPrincipal.ToArgb() || argb == FondoTarjeta.ToArgb() || argb == FondoMenu.ToArgb());
        }

        /// <summary>El control dibuja el degradado de fondo (formularios y pestañas).</summary>
        private static void UsarDegradado(Control control)
        {
            control.BackColor = FondoPrincipal;
            ActivarDobleBuffer(control);
            control.Paint += (s, e) => PintarDegradado((Control)s, e.Graphics, ((Control)s).ClientRectangle);

            // El degradado depende del tamaño de la ventana: al cambiar de tamaño se repinta todo.
            if (control is Form) control.Resize += (s, e) => ((Control)s).Invalidate(true);
        }

        /// <summary>Evita el parpadeo al repintar (DoubleBuffered es una propiedad protegida de Control).</summary>
        public static void ActivarDobleBuffer(Control control)
        {
            PropertyInfo propiedad = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (propiedad != null) propiedad.SetValue(control, true, null);
        }

        /// <summary>
        /// Pinta lo que se ve "detrás" del control: el degradado de la ventana y el vidrio de las tarjetas
        /// que lo contienen. Así las esquinas redondeadas y los controles sin relleno se ven transparentes.
        /// </summary>
        public static void PintarFondo(Control control, Graphics g)
        {
            PintarFondo(control, g, control.ClientRectangle);
        }

        /// <summary>Igual que PintarFondo, pero solo en una parte del control (por ejemplo, una celda).</summary>
        public static void PintarFondo(Control control, Graphics g, Rectangle area)
        {
            // 1) Subir por los contenedores: se guardan las tarjetas de vidrio hasta llegar a un fondo.
            List<PanelRedondeado> vidrios = new List<PanelRedondeado>();
            Color fondoSolido = Color.Empty;
            for (Control padre = control.Parent; padre != null; padre = padre.Parent)
            {
                PanelRedondeado tarjeta = padre as PanelRedondeado;
                if (tarjeta != null)
                {
                    if (tarjeta.ColorRelleno.A == 255) { fondoSolido = tarjeta.ColorRelleno; break; }
                    vidrios.Add(tarjeta);
                    continue;
                }
                if (padre is Form || padre is TabPage) break;          // estos dibujan el degradado
                if (padre.BackColor.A == 255) { fondoSolido = padre.BackColor; break; }
            }

            GraphicsState estado = g.Save();
            g.SetClip(area, CombineMode.Intersect);

            // 2) Fondo: color sólido o el degradado de la ventana.
            if (fondoSolido != Color.Empty)
                using (SolidBrush pincel = new SolidBrush(fondoSolido)) g.FillRectangle(pincel, area);
            else
                PintarDegradado(control, g, area);

            // 3) Vidrio de cada tarjeta, de la más externa a la más interna.
            for (int i = vidrios.Count - 1; i >= 0; i--)
            {
                Point posicion = PosicionDentroDe(control, vidrios[i]);
                GraphicsState antes = g.Save();
                g.TranslateTransform(-posicion.X, -posicion.Y);
                vidrios[i].PintarVidrio(g);
                g.Restore(antes);
            }

            g.Restore(estado);
        }

        /// <summary>Pinta el degradado de la ventana en la parte del control indicada.</summary>
        public static void PintarDegradado(Control control, Graphics g, Rectangle area)
        {
            // La ventana es el control de más arriba (si el formulario está dentro del Dashboard, es el Dashboard).
            Control ventana = control;
            while (ventana.Parent != null) ventana = ventana.Parent;
            if (ventana.ClientSize.Width <= 0 || ventana.ClientSize.Height <= 0) return;

            Point posicion = PosicionDentroDe(control, ventana);
            Bitmap degradado = ObtenerDegradado(ventana.ClientSize);
            Rectangle origen = new Rectangle(area.X + posicion.X, area.Y + posicion.Y, area.Width, area.Height);

            GraphicsState estado = g.Save();
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = PixelOffsetMode.Half;
            g.DrawImage(degradado, area, origen, GraphicsUnit.Pixel);
            g.Restore(estado);
        }

        /// <summary>Posición de un control dentro de uno de sus contenedores (sumando las posiciones).</summary>
        private static Point PosicionDentroDe(Control control, Control contenedor)
        {
            Point posicion = Point.Empty;
            for (Control actual = control; actual != null && actual != contenedor; actual = actual.Parent)
            {
                posicion.X += actual.Left;
                posicion.Y += actual.Top;
            }
            return posicion;
        }

        private static Bitmap ObtenerDegradado(Size tamano)
        {
            Bitmap degradado;
            if (degradadosGuardados.TryGetValue(tamano, out degradado)) return degradado;

            if (degradadosGuardados.Count > 6)
            {
                foreach (Bitmap viejo in degradadosGuardados.Values) viejo.Dispose();
                degradadosGuardados.Clear();
            }

            degradado = new Bitmap(tamano.Width, tamano.Height);
            using (Graphics g = Graphics.FromImage(degradado))
            {
                g.Clear(FondoPrincipal);
                float w = tamano.Width, h = tamano.Height;
                DibujarResplandor(g, new PointF(w * 0.08f, -h * 0.05f), new SizeF(w * 0.62f, h * 0.80f), ResplandorVioleta, 165);
                DibujarResplandor(g, new PointF(w * 1.02f, h * 0.55f), new SizeF(w * 0.48f, h * 0.85f), ResplandorTurquesa, 150);
                DibujarResplandor(g, new PointF(w * 0.30f, h * 1.08f), new SizeF(w * 0.42f, h * 0.50f), ResplandorRosa, 95);
            }
            degradadosGuardados[tamano] = degradado;
            return degradado;
        }

        /// <summary>Mancha de luz con forma de elipse que se desvanece hacia los bordes.</summary>
        private static void DibujarResplandor(Graphics g, PointF centro, SizeF radio, Color color, int opacidad)
        {
            using (GraphicsPath ruta = new GraphicsPath())
            {
                ruta.AddEllipse(centro.X - radio.Width, centro.Y - radio.Height, radio.Width * 2, radio.Height * 2);
                using (PathGradientBrush pincel = new PathGradientBrush(ruta))
                {
                    pincel.CenterPoint = centro;
                    pincel.CenterColor = ConOpacidad(color, opacidad);
                    pincel.SurroundColors = new[] { ConOpacidad(color, 0) };

                    // Caída suave: casi nada en el borde y la mayor intensidad en el centro.
                    Blend caida = new Blend();
                    caida.Positions = new[] { 0f, 0.25f, 0.5f, 0.75f, 1f };
                    caida.Factors = new[] { 0f, 0.08f, 0.30f, 0.62f, 1f };
                    pincel.Blend = caida;

                    g.FillPath(pincel, ruta);
                }
            }
        }

        #endregion

        #region Tablas de vidrio

        /// <summary>
        /// Tabla sencilla (sin EstiloConsulta) con el mismo vidrio que las tarjetas: encabezado y filas
        /// semitransparentes sobre el fondo. Sirve para tablas de detalle (por ejemplo, las líneas de una compra).
        /// </summary>
        public static void TablaDeVidrio(DataGridView dgv)
        {
            ActivarDobleBuffer(dgv);
            dgv.CellPainting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                bool encabezado = e.RowIndex < 0;
                bool seleccionada = !encabezado && dgv.Rows[e.RowIndex].Selected;

                PintarFondo(dgv, e.Graphics, e.CellBounds);
                Color capa = encabezado ? Vidrio
                           : seleccionada ? ConOpacidad(Acento, 46)
                           : (e.RowIndex % 2 == 0 ? Color.FromArgb(8, 255, 255, 255) : Color.Empty);
                if (capa != Color.Empty)
                    using (SolidBrush pincel = new SolidBrush(capa)) e.Graphics.FillRectangle(pincel, e.CellBounds);

                e.PaintContent(e.CellBounds);   // el texto, con los colores del estilo de la celda
                e.Handled = true;
            };
            dgv.Paint += (s, e) => PintarAreaVaciaTabla(dgv, e.Graphics);
        }

        /// <summary>
        /// Debajo de la última fila (y a la derecha de la última columna) el DataGridView pinta su color
        /// de fondo sólido. Se reemplaza por lo que hay detrás de la tabla para que se vea el vidrio.
        /// </summary>
        public static void PintarAreaVaciaTabla(DataGridView dgv, Graphics g)
        {
            int ultima = dgv.Rows.GetLastRow(DataGridViewElementStates.Displayed);
            int abajo = ultima >= 0 ? dgv.GetRowDisplayRectangle(ultima, false).Bottom
                                    : (dgv.ColumnHeadersVisible ? dgv.ColumnHeadersHeight : 0);
            if (abajo < dgv.Height)
                PintarFondo(dgv, g, new Rectangle(0, abajo, dgv.Width, dgv.Height - abajo));

            int derecha = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - dgv.HorizontalScrollingOffset;
            if (derecha < dgv.Width)
                PintarFondo(dgv, g, new Rectangle(derecha, 0, dgv.Width - derecha, abajo));
        }

        #endregion

        #region Formularios sin borde

        /// <summary>
        /// Redondea las esquinas de un formulario sin borde.
        /// En Windows 11 usa las esquinas nativas (suaves); en Windows 10 usa una Region con GraphicsPath.
        /// </summary>
        public static void RedondearFormulario(Form formulario, int radio)
        {
            if (formulario == null) return;

            bool esquinasNativas = false;
            try
            {
                int preferencia = NativeMethods.DWMWCP_ROUND;
                int resultado = NativeMethods.DwmSetWindowAttribute(formulario.Handle,
                    NativeMethods.DWMWA_WINDOW_CORNER_PREFERENCE, ref preferencia, sizeof(int));
                esquinasNativas = resultado == 0 && Environment.OSVersion.Version.Build >= 22000;
            }
            catch (DllNotFoundException) { }
            catch (EntryPointNotFoundException) { }

            if (esquinasNativas) return;

            AplicarRegionRedondeada(formulario, radio);
            formulario.Resize += (s, e) =>
            {
                if (formulario.WindowState == FormWindowState.Maximized)
                    formulario.Region = null;
                else
                    AplicarRegionRedondeada(formulario, radio);
            };
        }

        private static void AplicarRegionRedondeada(Control control, int radio)
        {
            using (GraphicsPath ruta = CrearRutaRedondeada(new Rectangle(0, 0, control.Width, control.Height), radio))
            {
                control.Region = new Region(ruta);
            }
        }

        /// <summary>Permite mover un formulario sin borde arrastrando cualquier control (encabezado, logo, etc.).</summary>
        public static void HabilitarArrastre(Form formulario, params Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.MouseDown += (s, e) =>
                {
                    if (e.Button != MouseButtons.Left || e.Clicks > 1) return;   // doble clic = maximizar
                    NativeMethods.ReleaseCapture();
                    NativeMethods.SendMessage(formulario.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
                };
            }
        }

        #endregion

        #region Barras de desplazamiento

        /// <summary>
        /// Barras de desplazamiento oscuras (Windows 10 1809+ / Windows 11).
        /// Funciona con DataGridView, paneles con AutoScroll y TextBox multilínea.
        /// </summary>
        public static void AplicarScrollOscuro(Control control)
        {
            if (control == null) return;
            if (!control.IsHandleCreated)
            {
                control.HandleCreated += (s, e) => AplicarScrollOscuro((Control)s);
                return;
            }
            try
            {
                NativeMethods.SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
                foreach (Control hijo in control.Controls)
                {
                    if (hijo is ScrollBar) NativeMethods.SetWindowTheme(hijo.Handle, "DarkMode_Explorer", null);
                }
            }
            catch (DllNotFoundException) { }
            catch (EntryPointNotFoundException) { }
        }

        #endregion
    }

    /// <summary>Llamadas a la API de Windows usadas por la capa visual.</summary>
    internal static class NativeMethods
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
        public const int DWMWCP_ROUND = 2;
        public const int CS_DROPSHADOW = 0x00020000;
        public const int WS_MINIMIZEBOX = 0x00020000;
        public const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int pvAttribute, int cbAttribute);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
    }
}
