using System;
using System.Drawing;
using System.Windows.Forms;
using Entidad;
using FerreteriaSistema.UI;
using FerreteriaSistema.UI.Controles;
using FontAwesome.Sharp;
using Negocio;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Pantalla CRUD de Sucursales (Capa Presentación).
    /// No se conecta a SQL Server: todas las operaciones pasan por SucursalNegocio.
    /// </summary>
    public partial class SucursalesForm : Form
    {
        private string modoActual = "Inicial";
        private EstiloConsulta consulta;
        private readonly SucursalNegocio sucursalNegocio = new SucursalNegocio();

        public SucursalesForm()
        {
            InitializeComponent();
        }

        private void SucursalesForm_Load(object sender, EventArgs e)
        {
            Tema.AplicarScrollOscuro(dgvDatos);
            Tema.AplicarScrollOscuro(pnlFormulario);
            lblModo.Left = lblTitulo.Right + 10;
            MtdConfigurarConsulta();

            // Solo se muestran las columnas del diseño (no se generan columnas extra).
            dgvDatos.AutoGenerateColumns = false;

            MtdSeleccionarPestana(0);
            MtdControlarCampos("Inicial");
            MtdCargarDatos();
        }

        #region Consultar

        /// <summary>Consultar: carga todas las sucursales en la tabla.</summary>
        private void MtdCargarDatos()
        {
            try
            {
                dgvDatos.DataSource = sucursalNegocio.Listar();
            }
            catch (Exception ex)
            {
                MtdMostrarError("No se pudieron cargar las sucursales.", ex);
            }
            MtdActualizarContador();
        }

        /// <summary>Muestra "Activa" o "Inactiva" en lugar de True/False en la columna Estado.</summary>
        private void dgvDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].Name != "colEstado" || !(e.Value is bool)) return;

            e.Value = (bool)e.Value ? "Activa" : "Inactiva";
            e.FormattingApplied = true;
        }

        #endregion

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
            txtNombre.Enabled = camposHabilitados;
            cboTipoSucursal.Enabled = camposHabilitados;
            txtDireccion.Enabled = camposHabilitados;
            txtObservaciones.Enabled = camposHabilitados;
            txtCodigoSucursal.Enabled = false; // Código: siempre bloqueado (lo genera la base de datos)

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
            txtCodigoSucursal.Clear();
            txtCodigoSucursal.ColorBorde = Tema.Borde;
            chkEstado.Checked = true;
            txtNombre.Clear();
            txtNombre.ColorBorde = Tema.Borde;
            cboTipoSucursal.SelectedIndex = -1;
            cboTipoSucursal.ColorBorde = Tema.Borde;
            txtDireccion.Clear();
            txtDireccion.ColorBorde = Tema.Borde;
            txtObservaciones.Clear();
            txtObservaciones.ColorBorde = Tema.Borde;
        }

        #endregion

        #region Botones de acción

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Nuevo");
            MtdSeleccionarPestana(1);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Editar");
            MtdSeleccionarPestana(1);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!MtdHayFilaSeleccionada()) return;
            MtdCargarFilaSeleccionada();
            MtdControlarCampos("Eliminar");
            MtdSeleccionarPestana(1);
        }

        /// <summary>
        /// Guarda según el modo actual:
        /// "Nuevo" = Agregar, "Editar" = Editar, "Eliminar" = borrado lógico (estado Inactiva).
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            string mensajeExito;

            try
            {
                if (modoActual == "Eliminar")
                {
                    DialogResult respuesta = MessageBox.Show(
                        "¿Seguro que deseas eliminar la sucursal seleccionada?\nNo se borrará: quedará con estado Inactiva.",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta != DialogResult.Yes) return;

                    int.TryParse(txtCodigoSucursal.Text, out int codigoSucursal);
                    mensajeError = sucursalNegocio.Eliminar(codigoSucursal);
                    mensajeExito = "La sucursal quedó inactiva.";
                }
                else
                {
                    if (!MtdValidarCampos()) return;

                    Sucursal sucursal = MtdLeerCampos();
                    if (modoActual == "Nuevo")
                    {
                        mensajeError = sucursalNegocio.Insertar(sucursal);
                        mensajeExito = "Sucursal agregada correctamente.";
                    }
                    else
                    {
                        mensajeError = sucursalNegocio.Actualizar(sucursal);
                        mensajeExito = "Sucursal actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                MtdMostrarError("No se pudo guardar la información.", ex);
                return;
            }

            // Si Negocio devolvió un mensaje, el usuario corrige sin perder lo escrito.
            if (mensajeError != "")
            {
                MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(mensajeExito, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MtdControlarCampos("Inicial");
            MtdSeleccionarPestana(0);
            txtBuscar.Clear();
            MtdCargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdControlarCampos("Inicial");
            MtdSeleccionarPestana(0);
        }

        /// <summary>Buscar: filtra por nombre, dirección o tipo. Con el texto vacío muestra todas.</summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDatos.DataSource = sucursalNegocio.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MtdMostrarError("No se pudo realizar la búsqueda.", ex);
            }
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
            consulta.Codigo("colCodigoSucursal", "SUC");
            consulta.DosLineas("colNombreSucursal", "colDireccionSucursal", IconChar.Store);
            consulta.Insignia("colTipoSucursal", IconChar.Warehouse);
            consulta.Estado("colEstado", "Activa", "Inactiva");
            consulta.Acciones("colAcciones", () => btnEditar_Click(btnEditar, EventArgs.Empty), "colObservaciones");

            // Filtros: qué filas muestra cada chip
            consulta.AgregarFiltro(chpTodos, "Todos", null, Color.Empty);
            consulta.AgregarFiltro(chpActivas, "Activas", fila => EstiloConsulta.EsActivo(fila, "colEstado"), Tema.Exito);
            consulta.AgregarFiltro(chpInactivas, "Inactivas", fila => !EstiloConsulta.EsActivo(fila, "colEstado"), Tema.Peligro);
            consulta.AgregarFiltro(chpMatriz, "Matriz", fila => EstiloConsulta.Texto(fila, "colTipoSucursal") == "Matriz", Tema.Acento);
            consulta.AgregarFiltro(chpBodegas, "Bodegas", fila => EstiloConsulta.Texto(fila, "colTipoSucursal") == "Bodega", Tema.Advertencia);
        }

        /// <summary>Valores de las tarjetas de resumen.</summary>
        private void MtdActualizarResumen()
        {
            tarjTotal.Valor = consulta.TotalRegistros.ToString("N0");
            int inactivas = consulta.Contar(fila => !EstiloConsulta.EsActivo(fila, "colEstado"));
            tarjResumen.Valor = inactivas.ToString("N0");
            tarjResumen.Insignia = inactivas > 0 ? inactivas.ToString() : "";
        }

        #endregion

        #region Métodos auxiliares visuales

        /// <summary>Validación visual de campos obligatorios (borde rojo en el campo vacío).</summary>
        private bool MtdValidarCampos()
        {
            bool valido = true;
            valido &= MtdCampoRequerido(txtNombre);
            valido &= MtdCampoRequerido(cboTipoSucursal);
            valido &= MtdCampoRequerido(txtDireccion);

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

        /// <summary>Copia la sucursal de la fila seleccionada a los controles de la pestaña Gestionar.</summary>
        private void MtdCargarFilaSeleccionada()
        {
            // Cada fila de la tabla está enlazada a un objeto Sucursal (DataBoundItem).
            Sucursal sucursal = dgvDatos.CurrentRow?.DataBoundItem as Sucursal;
            if (sucursal == null) return;

            txtCodigoSucursal.Text = sucursal.CodigoSucursal.ToString();
            chkEstado.Checked = sucursal.EstadoSucursal;
            txtNombre.Text = sucursal.NombreSucursal;
            cboTipoSucursal.SelectedIndex = cboTipoSucursal.FindStringExact(sucursal.TipoSucursal);
            txtDireccion.Text = sucursal.DireccionSucursal;
            txtObservaciones.Text = sucursal.Observaciones;
        }

        /// <summary>Crea un objeto Sucursal con lo escrito en la pestaña Gestionar.</summary>
        private Sucursal MtdLeerCampos()
        {
            Sucursal sucursal = new Sucursal();
            int.TryParse(txtCodigoSucursal.Text, out int codigoSucursal); // en "Nuevo" queda en 0
            sucursal.CodigoSucursal = codigoSucursal;
            sucursal.NombreSucursal = txtNombre.Text;
            sucursal.TipoSucursal = Convert.ToString(cboTipoSucursal.SelectedItem);
            sucursal.DireccionSucursal = txtDireccion.Text;
            sucursal.EstadoSucursal = chkEstado.Checked;
            sucursal.Observaciones = txtObservaciones.Text;
            return sucursal;
        }

        private static void MtdMostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(mensaje + "\n\nDetalle: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
