using System;
using System.Drawing;
using System.Windows.Forms;
using FerreteriaSistema.UI;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Pantalla CRUD de Inventario (Capa Presentación).
    /// Contiene únicamente código visual y de navegación. Los puntos marcados con
    /// "TODO (Capa Negocio)" son donde se conectarán las clases de la capa de negocio.
    /// </summary>
    public partial class InventarioForm : Form
    {
        private string modoActual = "Inicial";
        private EstiloConsulta consulta;

        public InventarioForm()
        {
            InitializeComponent();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
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
            cboSucursal.Enabled = camposHabilitados;
            txtNombreInventario.Enabled = camposHabilitados;
            txtUbicacion.Enabled = camposHabilitados;
            txtCantidadInventario.Enabled = camposHabilitados;
            txtCantidadMinimaInventario.Enabled = camposHabilitados;
            txtObservaciones.Enabled = camposHabilitados;
            txtCodigoInventario.Enabled = false; // Código: siempre bloqueado (lo genera la base de datos)

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
            txtCodigoInventario.Clear();
            txtCodigoInventario.ColorBorde = Tema.Borde;
            cboSucursal.SelectedIndex = -1;
            cboSucursal.ColorBorde = Tema.Borde;
            txtNombreInventario.Clear();
            txtNombreInventario.ColorBorde = Tema.Borde;
            txtUbicacion.Clear();
            txtUbicacion.ColorBorde = Tema.Borde;
            txtCantidadInventario.Clear();
            txtCantidadInventario.ColorBorde = Tema.Borde;
            txtCantidadMinimaInventario.Clear();
            txtCantidadMinimaInventario.ColorBorde = Tema.Borde;
            txtObservaciones.Clear();
            txtObservaciones.ColorBorde = Tema.Borde;
        }

        #endregion

        #region Botones de acción

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Nuevo");
            MtdSeleccionarPestana(1);
            cboSucursal.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Editar");
            MtdSeleccionarPestana(1);
            cboSucursal.Focus();
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
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminar el inventario seleccionado?",
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
            // Se llama al método directamente: PerformClick no funciona porque btnEditar
            // está en la pestaña Gestionar, que no es visible mientras se está en Consultar.
            if (e.RowIndex >= 0 && modoActual == "Inicial") btnEditar_Click(btnEditar, EventArgs.Empty);
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
            consulta.Codigo("colCodigoInventario", "INV");
            consulta.Insignia("colCodigoSucursal", IconChar.Store, "Sucursal {0}");
            consulta.DosLineas("colNombreInventario", null, IconChar.BoxesStacked);
            consulta.Insignia("colUbicacion", IconChar.LocationDot);
            consulta.Barra("colCantidadInventario", "colCantidadMinimaInventario", "uds.", MtdColorBarra);
            consulta.Insignia("colCantidadMinimaInventario", IconChar.None, "Mínimo ({0})", MtdColorStock);
            consulta.Acciones("colAcciones", () => btnEditar_Click(btnEditar, EventArgs.Empty), "colObservaciones");

            // Filtros: qué filas muestra cada chip
            consulta.AgregarFiltro(chpTodos, "Todos", null, Color.Empty);
            consulta.AgregarFiltro(chpStockBajo, "Stock bajo", MtdStockBajo, Tema.Advertencia);
            consulta.AgregarFiltro(chpCriticos, "Críticos", MtdEsCritico, Tema.Peligro);
        }

        /// <summary>Valores de las tarjetas de resumen.</summary>
        private void MtdActualizarResumen()
        {
            tarjTotal.Valor = consulta.TotalRegistros.ToString("N0");
            int alertas = consulta.Contar(fila => MtdStockBajo(fila) || MtdEsCritico(fila));
            tarjResumen.Valor = alertas.ToString("N0");
            tarjResumen.Insignia = alertas > 0 ? alertas.ToString() : "";
        }

        /// <summary>Crítico: la cantidad llegó a la cantidad mínima o está por debajo.</summary>
        private static bool MtdEsCritico(DataGridViewRow fila)
        {
            return EstiloConsulta.Numero(fila, "colCantidadInventario") <= EstiloConsulta.Numero(fila, "colCantidadMinimaInventario");
        }

        /// <summary>Stock bajo: todavía no es crítico, pero la cantidad es menor o igual a 1.5 veces el mínimo.</summary>
        private static bool MtdStockBajo(DataGridViewRow fila)
        {
            decimal cantidad = EstiloConsulta.Numero(fila, "colCantidadInventario");
            decimal minimo = EstiloConsulta.Numero(fila, "colCantidadMinimaInventario");
            return cantidad > minimo && cantidad <= minimo * 1.5m;
        }

        /// <summary>Color de la insignia "Mínimo": rojo crítico, naranja bajo, verde normal.</summary>
        private static Color MtdColorStock(DataGridViewRow fila)
        {
            if (MtdEsCritico(fila)) return Tema.Peligro;
            if (MtdStockBajo(fila)) return Tema.Advertencia;
            return Tema.Exito;
        }

        /// <summary>Color de la barra de cantidad: rojo crítico, naranja bajo, azul normal.</summary>
        private static Color MtdColorBarra(DataGridViewRow fila)
        {
            if (MtdEsCritico(fila)) return Tema.Peligro;
            if (MtdStockBajo(fila)) return Tema.Advertencia;
            return Tema.Acento;
        }

        #endregion

        #region Métodos auxiliares visuales

        /// <summary>Validación visual de campos obligatorios (borde rojo en el campo vacío).</summary>
        private bool MtdValidarCampos()
        {
            bool valido = true;
            valido &= MtdCampoRequerido(cboSucursal);
            valido &= MtdCampoRequerido(txtNombreInventario);
            valido &= MtdCampoRequerido(txtUbicacion);
            valido &= MtdCampoRequerido(txtCantidadInventario);
            valido &= MtdCampoRequerido(txtCantidadMinimaInventario);

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

            txtCodigoInventario.Text = MtdValorCelda(fila, "colCodigoInventario");
            cboSucursal.SelectedIndex = cboSucursal.FindStringExact(MtdValorCelda(fila, "colCodigoSucursal"));
            txtNombreInventario.Text = MtdValorCelda(fila, "colNombreInventario");
            txtUbicacion.Text = MtdValorCelda(fila, "colUbicacion");
            txtCantidadInventario.Text = MtdValorCelda(fila, "colCantidadInventario");
            txtCantidadMinimaInventario.Text = MtdValorCelda(fila, "colCantidadMinimaInventario");
            txtObservaciones.Text = MtdValorCelda(fila, "colObservaciones");
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
