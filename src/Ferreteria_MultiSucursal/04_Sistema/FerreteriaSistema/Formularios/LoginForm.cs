using System;
using System.Drawing;
using System.Windows.Forms;
using FerreteriaSistema.UI;
using FontAwesome.Sharp;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Panel de acceso (Capa Presentación). Solo contiene lógica visual y de navegación.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Tema.AplicarFondo(this);
        }

        /// <summary>Sombra suave alrededor del formulario sin bordes.</summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= NativeMethods.CS_DROPSHADOW;
                return cp;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Tema.RedondearFormulario(this, 18);
            Tema.HabilitarArrastre(this, this, icoLogo, lblTitulo, lblSubtitulo, lblPie);

            // TODO (Capa Negocio): llenar cboxSucursal con las sucursales activas de Tbl_Sucursales.
            if (cboxSucursal.Items.Count > 0) cboxSucursal.SelectedIndex = 0;

            lblMensaje.Text = string.Empty;
            ActiveControl = txtUsuario;
        }

        #region Eventos visuales

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!MtdValidarCampos()) return;

            // TODO (Capa Negocio): validar usuario, contraseña y sucursal antes de continuar.
            MtdAbrirDashboard();
        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            bool ocultar = !txtContrasena.UseSystemPasswordChar;
            txtContrasena.UseSystemPasswordChar = ocultar;
            btnVerContrasena.IconChar = ocultar ? IconChar.Eye : IconChar.EyeSlash;
            txtContrasena.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Métodos visuales

        /// <summary>Validación visual: resalta en rojo el campo vacío y muestra el mensaje.</summary>
        private bool MtdValidarCampos()
        {
            txtUsuario.ColorBorde = Tema.Borde;
            txtContrasena.ColorBorde = Tema.Borde;
            cboxSucursal.ColorBorde = Tema.Borde;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                return MtdMostrarError("Ingresa tu nombre de usuario.", txtUsuario);

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                return MtdMostrarError("Ingresa tu contraseña.", txtContrasena);

            if (cboxSucursal.SelectedIndex < 0)
            {
                cboxSucursal.ColorBorde = Tema.Peligro;
                lblMensaje.Text = "Selecciona una sucursal.";
                cboxSucursal.Focus();
                return false;
            }

            lblMensaje.Text = string.Empty;
            return true;
        }

        private bool MtdMostrarError(string mensaje, FerreteriaSistema.UI.Controles.TextBoxOscuro campo)
        {
            campo.ColorBorde = Tema.Peligro;
            lblMensaje.Text = mensaje;
            campo.Focus();
            return false;
        }

        /// <summary>Abre el Dashboard y oculta el Login. Al cerrar sesión, el Login vuelve a mostrarse.</summary>
        private void MtdAbrirDashboard()
        {
            DashboardForm dashboard = new DashboardForm(txtUsuario.Text.Trim(), cboxSucursal.Text);
            dashboard.FormClosed += Dashboard_FormClosed;
            Hide();
            dashboard.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardForm dashboard = (DashboardForm)sender;
            if (dashboard.SesionCerrada)
            {
                txtContrasena.Clear();
                txtContrasena.UseSystemPasswordChar = true;
                btnVerContrasena.IconChar = IconChar.Eye;
                lblMensaje.Text = string.Empty;
                Show();
                txtContrasena.Focus();
            }
            else
            {
                Close();   // Cierra la aplicación.
            }
        }

        #endregion
    }
}
