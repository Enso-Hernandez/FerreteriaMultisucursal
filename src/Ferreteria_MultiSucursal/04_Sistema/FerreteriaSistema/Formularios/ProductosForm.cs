using System;
using System.Drawing;
using System.Windows.Forms;
using FerreteriaSistema.UI;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Pantalla CRUD de Productos (Capa Presentación).
    /// Contiene únicamente código visual y de navegación. Los puntos marcados con
    /// "TODO (Capa Negocio)" son donde se conectarán las clases de la capa de negocio.
    /// </summary>
    public partial class ProductosForm : Form
    {
        private string modoActual = "Inicial";
        private EstiloConsulta consulta;

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            Tema.AplicarScrollOscuro(dgvDatos);
            Tema.AplicarScrollOscuro(pnlFormulario);
            lblModo.Left = lblTitulo.Right + 10;
            MtdConfigurarConsulta();

            // TODO (Capa Negocio): cargar dgvDatos y los ComboBox con datos reales.
            MtdSeleccionarPestana(0);
            MtdControlarCampos("Inicial");
            MtdActualizarContador();
        }

        #region Navegación visual (pestañas)

        private void btnTabConsultar_Click(object sender, EventArgs e)
        {
            MtdSeleccionarPestana(0);
        }

        private void btnTabGestionar_Click(object sender, EventArgs e)
        {
            MtdSeleccionarPestana(1);
        }

        /// <summary>Cambia de pestaña y resalta el botón activo (las pestañas nativas están ocultas).</summary>
        private void MtdSeleccionarPestana(int indice)
        {
            tabPrincipal.SelectedIndex = indice;
            MtdEstiloPestana(btnTabConsultar, indice == 0);
            MtdEstiloPestana(btnTabGestionar, indice == 1);
        }

        private static void MtdEstiloPestana(BotonRedondeado boton, bool activa)
        {
            boton.BackColor = activa ? Tema.Acento : Tema.FondoSecundario;
            boton.ForeColor = activa ? Color.White : Tema.TextoSecundario;
            boton.IconColor = boton.ForeColor;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Control de estados visuales

        /// <summary>
        /// Bloquea o desbloquea campos y botones según el modo:
        /// "Inicial", "Nuevo", "Editar" o "Eliminar".
        /// </summary>
        private void MtdControlarCampos(string modo)
        {
            bool camposHabilitados;
            bool limpiar;
            bool btnNuevoActivo, btnEditarActivo, btnEliminarActivo, btnGuardarActivo, btnCancelarActivo;

            switch (modo)
            {
                case "Nuevo":
                    camposHabilitados = true; limpiar = true;
                    btnNuevoActivo = false; btnEditarActivo = false; btnEliminarActivo = false;
                    btnGuardarActivo = true; btnCancelarActivo = true;
                    break;

                case "Editar":
                    camposHabilitados = true; limpiar = false;
                    btnNuevoActivo = false; btnEditarActivo = false; btnEliminarActivo = false;
                    btnGuardarActivo = true; btnCancelarActivo = true;
                    break;

                case "Eliminar":
                    // Solo lectura: el usuario revisa el registro y confirma con el botón Guardar ("Confirmar").
                    camposHabilitados = false; limpiar = false;
                    btnNuevoActivo = false; btnEditarActivo = false; btnEliminarActivo = false;
                    btnGuardarActivo = true; btnCancelarActivo = true;
                    break;

                default: // "Inicial"
                    modo = "Inicial";
                    camposHabilitados = false; limpiar = true;
                    btnNuevoActivo = true; btnEditarActivo = true; btnEliminarActivo = true;
                    btnGuardarActivo = false; btnCancelarActivo = false;
                    break;
            }

            modoActual = modo;
            if (limpiar) MtdLimpiarCampos();

            // Campos de la pestaña Gestionar
            chkEstado.Enabled = camposHabilitados;
            txtNombreProducto.Enabled = camposHabilitados;
            cboCategoria.Enabled = camposHabilitados;
            cboUnidadMedida.Enabled = camposHabilitados;
            txtPrecio.Enabled = camposHabilitados;
            txtDescripcion.Enabled = camposHabilitados;
            txtCodigoProducto.Enabled = false; // Código: siempre bloqueado (lo genera la base de datos)

            // Botones de acción
            btnNuevo.Enabled = btnNuevoActivo;
            btnEditar.Enabled = btnEditarActivo;
            btnEliminar.Enabled = btnEliminarActivo;
            btnGuardar.Enabled = btnGuardarActivo;
            btnCancelar.Enabled = btnCancelarActivo;

            // En modo Eliminar el botón Guardar se convierte en "Confirmar" (rojo).
            bool confirmarEliminacion = modo == "Eliminar";
            btnGuardar.Text = confirmarEliminacion ? "Confirmar" : "Guardar";
            btnGuardar.IconChar = confirmarEliminacion ? IconChar.TrashCan : IconChar.FloppyDisk;
            btnGuardar.BackColor = confirmarEliminacion ? Tema.Peligro : Tema.Exito;

            MtdActualizarIndicadorModo(modo);
        }

        /// <summary>Muestra el modo actual junto al título (color según la acción).</summary>
        private void MtdActualizarIndicadorModo(string modo)
        {
            switch (modo)
            {
                case "Nuevo": lblModo.Text = "●  Nuevo registro"; lblModo.ForeColor = Tema.Acento; break;
                case "Editar": lblModo.Text = "●  Editando"; lblModo.ForeColor = Tema.Advertencia; break;
                case "Eliminar": lblModo.Text = "●  Eliminar registro"; lblModo.ForeColor = Tema.Peligro; break;
                default: lblModo.Text = "●  Consulta"; lblModo.ForeColor = Tema.TextoSecundario; break;
            }
        }

        private void MtdLimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtCodigoProducto.ColorBorde = Tema.Borde;
            chkEstado.Checked = true;
            txtNombreProducto.Clear();
            txtNombreProducto.ColorBorde = Tema.Borde;
            cboCategoria.SelectedIndex = -1;
            cboCategoria.ColorBorde = Tema.Borde;
            cboUnidadMedida.SelectedIndex = -1;
            cboUnidadMedida.ColorBorde = Tema.Borde;
            txtPrecio.Clear();
            txtPrecio.ColorBorde = Tema.Borde;
            txtDescripcion.Clear();
            txtDescripcion.ColorBorde = Tema.Borde;
        }

        #endregion

        #region Botones de acción

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Nuevo");
            MtdSeleccionarPestana(1);
            txtNombreProducto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Editar");
            MtdSeleccionarPestana(1);
            txtNombreProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Eliminar");
            MtdSeleccionarPestana(1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modoActual == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminar el producto seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta != DialogResult.Yes) return;

                // TODO (Capa Negocio): eliminar (o desactivar) el registro.
            }
            else
            {
                if (!MtdValidarCampos()) return;

                // TODO (Capa Negocio): insertar si modoActual == "Nuevo" o actualizar si modoActual == "Editar".
            }

            MtdControlarCampos("Inicial");
            MtdSeleccionarPestana(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Inicial");
            MtdSeleccionarPestana(0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO (Capa Negocio): dgvDatos.DataSource = <lista filtrada por txtBuscar.Text>;
            MtdActualizarContador();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            btnBuscar.PerformClick();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && modoActual == "Inicial") btnEditar.PerformClick();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) { MtdActualizarContador(); }
        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) { MtdActualizarContador(); }
        private void dgvDatos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) { MtdActualizarContador(); }

        #endregion

        #region Diseño de la pestaña Consultar

        /// <summary>Configura el diseño de la tabla, los filtros (chips) y las tarjetas de resumen.</summary>
        private void MtdConfigurarConsulta()
        {
            consulta = new EstiloConsulta(dgvDatos, lblRegistros, pagConsulta);
            consulta.TarjetaActualizacion = tarjActualizacion;

            // Cómo se dibuja cada columna
            consulta.Codigo("colCodigoProducto", "PRO");
            consulta.DosLineas("colNombreProducto", "colDescripcion", IconChar.Box);
            consulta.Insignia("colCategoria", IconChar.Tag);
            consulta.Insignia("colUnidadMedida", IconChar.BoxesStacked);
            consulta.Moneda("colPrecio");
            consulta.Estado("colEstado", "Activo", "Inactivo");
            consulta.Acciones("colAcciones", () => btnEditar_Click(btnEditar, EventArgs.Empty));

            // Filtros: qué filas muestra cada chip
            consulta.AgregarFiltro(chpTodos, "Todos", null, Color.Empty);
            consulta.AgregarFiltro(chpActivos, "Activos", fila => EstiloConsulta.EsActivo(fila, "colEstado"), Tema.Exito);
            consulta.AgregarFiltro(chpInactivos, "Inactivos", fila => !EstiloConsulta.EsActivo(fila, "colEstado"), Tema.Peligro);
        }

        /// <summary>Valores de las tarjetas de resumen.</summary>
        private void MtdActualizarResumen()
        {
            tarjTotal.Valor = consulta.TotalRegistros.ToString("N0");
            int inactivos = consulta.Contar(fila => !EstiloConsulta.EsActivo(fila, "colEstado"));
            tarjResumen.Valor = inactivos.ToString("N0");
            tarjResumen.Insignia = inactivos > 0 ? inactivos.ToString() : "";
        }

        #endregion

        #region Métodos auxiliares visuales

        /// <summary>Validación visual de campos obligatorios (borde rojo en el campo vacío).</summary>
        private bool MtdValidarCampos()
        {
            bool valido = true;
            valido &= MtdCampoRequerido(txtNombreProducto);
            valido &= MtdCampoRequerido(cboCategoria);
            valido &= MtdCampoRequerido(cboUnidadMedida);
            valido &= MtdCampoRequerido(txtPrecio);

            if (!valido)
                MessageBox.Show("Completa los campos obligatorios marcados en rojo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            return valido;
        }

        private static bool MtdCampoRequerido(TextBoxOscuro campo)
        {
            bool lleno = !string.IsNullOrWhiteSpace(campo.Text);
            campo.ColorBorde = lleno ? Tema.Borde : Tema.Peligro;
            return lleno;
        }

        private static bool MtdCampoRequerido(ComboBoxOscuro campo)
        {
            bool lleno = campo.SelectedIndex >= 0;
            campo.ColorBorde = lleno ? Tema.Borde : Tema.Peligro;
            return lleno;
        }

        private bool MtdHayFilaSeleccionada()
        {
            if (dgvDatos.CurrentRow != null) return true;
            MessageBox.Show("Selecciona un registro en la pestaña Consultar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MtdSeleccionarPestana(0);
            return false;
        }

        /// <summary>Copia los valores de la fila seleccionada a los controles de la pestaña Gestionar.</summary>
        private void MtdCargarFilaSeleccionada()
        {
            DataGridViewRow fila = dgvDatos.CurrentRow;
            if (fila == null) return;

            txtCodigoProducto.Text = MtdValorCelda(fila, "colCodigoProducto");
            chkEstado.Checked = MtdEsActivo(fila.Cells["colEstado"].Value);
            txtNombreProducto.Text = MtdValorCelda(fila, "colNombreProducto");
            cboCategoria.SelectedIndex = cboCategoria.FindStringExact(MtdValorCelda(fila, "colCategoria"));
            cboUnidadMedida.SelectedIndex = cboUnidadMedida.FindStringExact(MtdValorCelda(fila, "colUnidadMedida"));
            txtPrecio.ValorDecimal = MtdDecimalCelda(fila, "colPrecio");
            txtDescripcion.Text = MtdValorCelda(fila, "colDescripcion");
        }

        private static string MtdValorCelda(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return valor == null || valor == DBNull.Value ? string.Empty : Convert.ToString(valor);
        }

        private static decimal MtdDecimalCelda(DataGridViewRow fila, string columna)
        {
            decimal valor;
            return decimal.TryParse(MtdValorCelda(fila, columna), out valor) ? valor : 0m;
        }

        private static bool MtdEsActivo(object valor)
        {
            string texto = Convert.ToString(valor).Trim().ToLowerInvariant();
            return texto == "true" || texto == "1" || texto == "activo" || texto == "a";
        }

        private void MtdActualizarContador()
        {
            if (consulta == null) return; // la consulta todavía no está configurada
            consulta.Actualizar();
            MtdActualizarResumen();
        }

        #endregion
    }
}
