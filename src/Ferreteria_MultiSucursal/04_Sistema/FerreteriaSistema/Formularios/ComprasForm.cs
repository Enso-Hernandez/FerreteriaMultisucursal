using System;
using System.Drawing;
using System.Windows.Forms;
using FerreteriaSistema.UI;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Pantalla CRUD de Compras (Capa Presentación).
    /// Contiene únicamente código visual y de navegación. Los puntos marcados con
    /// "TODO (Capa Negocio)" son donde se conectarán las clases de la capa de negocio.
    /// </summary>
    public partial class ComprasForm : Form
    {
        private string modoActual = "Inicial";
        private EstiloConsulta consulta;

        public ComprasForm()
        {
            InitializeComponent();
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            Tema.AplicarScrollOscuro(dgvDatos);
            Tema.AplicarScrollOscuro(dgvDetalle);
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
            cboProveedor.Enabled = camposHabilitados;
            cboSucursal.Enabled = camposHabilitados;
            dtpFecha.Enabled = camposHabilitados;
            txtCodigoCompra.Enabled = false; // Código: siempre bloqueado (lo genera la base de datos)
            cboProducto.Enabled = camposHabilitados && modo == "Nuevo";
            txtCantidad.Enabled = camposHabilitados && modo == "Nuevo";
            txtCosto.Enabled = camposHabilitados && modo == "Nuevo";
            btnAgregarDetalle.Enabled = camposHabilitados && modo == "Nuevo";
            btnQuitarDetalle.Enabled = camposHabilitados && modo == "Nuevo";

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
            txtCodigoCompra.Clear();
            txtCodigoCompra.ColorBorde = Tema.Borde;
            cboProveedor.SelectedIndex = -1;
            cboProveedor.ColorBorde = Tema.Borde;
            cboSucursal.SelectedIndex = -1;
            cboSucursal.ColorBorde = Tema.Borde;
            dtpFecha.Value = DateTime.Today;
            MtdLimpiarDetalle();
            dgvDetalle.Rows.Clear();
            MtdCalcularTotal();
        }

        #endregion

        #region Botones de acción

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Nuevo");
            MtdSeleccionarPestana(1);
            cboProveedor.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Editar");
            MtdSeleccionarPestana(1);
            cboProveedor.Focus();
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
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminar la compra seleccionada?",
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

        #region Detalle de la compra (solo visual)

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            bool valido = true;
            cboProducto.ColorBorde = cboProducto.SelectedIndex >= 0 ? Tema.Borde : Tema.Peligro;
            txtCantidad.ColorBorde = txtCantidad.ValorDecimal > 0 ? Tema.Borde : Tema.Peligro;
            txtCosto.ColorBorde = txtCosto.ValorDecimal > 0 ? Tema.Borde : Tema.Peligro;
            if (cboProducto.SelectedIndex < 0 || txtCantidad.ValorDecimal <= 0 || txtCosto.ValorDecimal <= 0) valido = false;
            if (!valido)
            {
                MessageBox.Show("Selecciona un producto e ingresa cantidad y costo mayores a cero.", "Detalle incompleto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal cantidad = txtCantidad.ValorDecimal;
            decimal costo = txtCosto.ValorDecimal;
            dgvDetalle.Rows.Add(cboProducto.Text, cantidad, costo, cantidad * costo);
            MtdCalcularTotal();
            MtdLimpiarDetalle();
            cboProducto.Focus();
        }

        private void btnQuitarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null) return;
            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            MtdCalcularTotal();
        }

        private void MtdLimpiarDetalle()
        {
            cboProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            txtCosto.Clear();
            cboProducto.ColorBorde = Tema.Borde;
            txtCantidad.ColorBorde = Tema.Borde;
            txtCosto.ColorBorde = Tema.Borde;
        }

        private void MtdCalcularTotal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
                total += Convert.ToDecimal(fila.Cells["colDetSubtotal"].Value);
            lblTotal.Text = total.ToString("Q #,##0.00");
        }

        #endregion

        #region Diseño de la pestaña Consultar

        /// <summary>Configura el diseño de la tabla, los filtros (chips) y las tarjetas de resumen.</summary>
        private void MtdConfigurarConsulta()
        {
            consulta = new EstiloConsulta(dgvDatos, lblRegistros, pagConsulta);
            consulta.TarjetaActualizacion = tarjActualizacion;

            // Cómo se dibuja cada columna
            consulta.Codigo("colCodigoCompra", "COM");
            consulta.Insignia("colProveedor", IconChar.Truck);
            consulta.Insignia("colSucursal", IconChar.Store);
            consulta.Moneda("colTotal");
            consulta.Estado("colEstado", "Activa", "Anulada");
            consulta.Acciones("colAcciones", () => btnEditar_Click(btnEditar, EventArgs.Empty));

            // Filtros: qué filas muestra cada chip
            consulta.AgregarFiltro(chpTodos, "Todos", null, Color.Empty);
            consulta.AgregarFiltro(chpEsteMes, "Este mes", fila => MtdEsDeEsteMes(EstiloConsulta.Fecha(fila, "colFecha")), Tema.Acento);
            consulta.AgregarFiltro(chpAnuladas, "Anuladas", fila => !EstiloConsulta.EsActivo(fila, "colEstado"), Tema.Peligro);
        }

        /// <summary>Valores de las tarjetas de resumen.</summary>
        private void MtdActualizarResumen()
        {
            tarjTotal.Valor = consulta.TotalRegistros.ToString("N0");
            tarjResumen.Valor = "Q " + consulta.Sumar("colTotal").ToString("N2");
        }

        private static bool MtdEsDeEsteMes(DateTime fecha)
        {
            return fecha.Year == DateTime.Today.Year && fecha.Month == DateTime.Today.Month;
        }

        #endregion

        #region Métodos auxiliares visuales

        /// <summary>Validación visual de campos obligatorios (borde rojo en el campo vacío).</summary>
        private bool MtdValidarCampos()
        {
            bool valido = true;
            valido &= MtdCampoRequerido(cboProveedor);
            valido &= MtdCampoRequerido(cboSucursal);

            if (valido && dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto al detalle de la compra.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

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

            txtCodigoCompra.Text = MtdValorCelda(fila, "colCodigoCompra");
            cboProveedor.SelectedIndex = cboProveedor.FindStringExact(MtdValorCelda(fila, "colProveedor"));
            cboSucursal.SelectedIndex = cboSucursal.FindStringExact(MtdValorCelda(fila, "colSucursal"));
            DateTime fecha;
            dtpFecha.Value = DateTime.TryParse(MtdValorCelda(fila, "colFecha"), out fecha) ? fecha : DateTime.Today;

            // TODO (Capa Negocio): cargar en dgvDetalle los productos de la compra seleccionada.
            dgvDetalle.Rows.Clear();
            MtdCalcularTotal();
        }

        private static string MtdValorCelda(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return valor == null || valor == DBNull.Value ? string.Empty : Convert.ToString(valor);
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
