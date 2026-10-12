using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FerreteriaSistema.UI;
using FontAwesome.Sharp;

namespace FerreteriaSistema.Formularios
{
    /// <summary>
    /// Menú principal (Capa Presentación): menú lateral, encabezado y contenedor de formularios hijos.
    /// </summary>
    public partial class DashboardForm : Form
    {
        private const int AnchoMenuExpandido = 240;
        private const int AnchoMenuColapsado = 64;

        private readonly string nombreUsuario;
        private readonly string nombreSucursal;
        private IconButton botonActivo;
        private Form formularioActivo;
        private bool menuColapsado;

        /// <summary>Indica si el usuario cerró sesión (para volver al Login) o cerró la aplicación.</summary>
        public bool SesionCerrada { get; private set; }

        // Constructor vacío requerido por el Diseñador de Visual Studio.
        public DashboardForm() : this("Administrador", "Sucursal Central")
        {
        }

        public DashboardForm(string usuario, string sucursal)
        {
            InitializeComponent();
            nombreUsuario = string.IsNullOrWhiteSpace(usuario) ? "Usuario" : usuario;
            nombreSucursal = string.IsNullOrWhiteSpace(sucursal) ? "Sin sucursal" : sucursal;
        }

        #region Ventana sin bordes (sombra, minimizar desde la barra de tareas y redimensionar)

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= NativeMethods.WS_MINIMIZEBOX;
                cp.ClassStyle |= NativeMethods.CS_DROPSHADOW;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int grosor = 8;

            if (m.Msg == WM_NCHITTEST && WindowState == FormWindowState.Normal)
            {
                base.WndProc(ref m);
                if ((int)m.Result == HTCLIENT)
                {
                    int lParam = unchecked((int)m.LParam.ToInt64());
                    Point cursor = PointToClient(new Point((short)(lParam & 0xFFFF), (short)((lParam >> 16) & 0xFFFF)));
                    bool izquierda = cursor.X <= grosor;
                    bool derecha = cursor.X >= ClientSize.Width - grosor;
                    bool arriba = cursor.Y <= grosor;
                    bool abajo = cursor.Y >= ClientSize.Height - grosor;

                    if (arriba && izquierda) m.Result = (IntPtr)13;
                    else if (arriba && derecha) m.Result = (IntPtr)14;
                    else if (abajo && izquierda) m.Result = (IntPtr)16;
                    else if (abajo && derecha) m.Result = (IntPtr)17;
                    else if (izquierda) m.Result = (IntPtr)10;
                    else if (derecha) m.Result = (IntPtr)11;
                    else if (arriba) m.Result = (IntPtr)12;
                    else if (abajo) m.Result = (IntPtr)15;
                }
                return;
            }
            base.WndProc(ref m);
        }

        #endregion

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            Tema.RedondearFormulario(this, 10);
            Tema.AplicarScrollOscuro(pnlBotonesMenu);
            Tema.HabilitarArrastre(this, pnlEncabezado, pnlMarca, lblTituloFormulario, iconFormularioActual,
                lblNombreSistema, lblNombreSistemaSub, pictureBoxLogo);

            if (pictureBoxLogo.Image == null)
                pictureBoxLogo.Image = IconChar.Toolbox.ToBitmap(IconFont.Solid, 48, Color.White);

            lblNombreUsuario.Text = nombreUsuario;
            lblSucursalActual.Text = nombreSucursal;
            lblBienvenida.Text = "Bienvenido, " + nombreUsuario;
            CultureInfo cultura = new CultureInfo("es-GT");
            string fecha = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", cultura);
            lblFecha.Text = char.ToUpper(fecha[0], cultura) + fecha.Substring(1) + "   ·   " + nombreSucursal;

            MtdMostrarInicio();
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            // Sin margen ni borde cuando la ventana está maximizada.
            Padding = WindowState == FormWindowState.Maximized ? new Padding(0) : new Padding(3);
            btnMaximizar.IconChar = WindowState == FormWindowState.Maximized ? IconChar.WindowRestore : IconChar.WindowMaximize;
        }

        #region Navegación: formularios hijos

        /// <summary>
        /// Dibuja un formulario dentro de pnlContenedorPrincipal (sin bordes, TopLevel = false).
        /// Los formularios antiguos (FrmXxx) reciben el tema oscuro automáticamente.
        /// </summary>
        public void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioHijo == null) return;

            Form anterior = formularioActivo;
            formularioActivo = formularioHijo;
            if (anterior != null) anterior.Close();

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Formularios que aún no fueron rediseñados: se les aplica la paleta Dark al vuelo.
            if (formularioHijo.GetType().Namespace != typeof(DashboardForm).Namespace)
                Tema.AplicarTemaOscuro(formularioHijo);

            pnlInicio.Visible = false;
            pnlContenedorPrincipal.Controls.Add(formularioHijo);
            pnlContenedorPrincipal.Tag = formularioHijo;
            formularioHijo.FormClosed += FormularioHijo_FormClosed;
            formularioHijo.BringToFront();
            formularioHijo.Show();

            lblTituloFormulario.Text = formularioHijo.Text;
        }

        private void FormularioHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Solo vuelve al inicio si se cerró el formulario que está visible.
            if (!ReferenceEquals(sender, formularioActivo)) return;
            formularioActivo = null;
            MtdMostrarInicio();
        }

        private void MtdMostrarInicio()
        {
            MtdDesactivarBoton();
            pnlInicio.Visible = true;
            pnlInicio.BringToFront();
            lblTituloFormulario.Text = "Inicio";
            iconFormularioActual.IconChar = IconChar.House;
        }

        #endregion

        #region Menú lateral: botón activo y colapsar

        private void MtdActivarBoton(object sender)
        {
            IconButton boton = sender as IconButton;
            if (boton == null) return;

            MtdDesactivarBoton();
            botonActivo = boton;
            botonActivo.BackColor = Tema.FondoSecundario;
            botonActivo.ForeColor = Color.White;
            botonActivo.IconColor = Tema.Acento;
            botonActivo.Font = new Font(botonActivo.Font, FontStyle.Bold);

            pnlIndicador.Location = new Point(0, botonActivo.Top);
            pnlIndicador.Height = botonActivo.Height;
            pnlIndicador.Visible = true;
            pnlIndicador.BringToFront();

            iconFormularioActual.IconChar = botonActivo.IconChar;
        }

        private void MtdDesactivarBoton()
        {
            if (botonActivo != null)
            {
                botonActivo.BackColor = Tema.FondoMenu;
                botonActivo.ForeColor = Tema.Texto;
                botonActivo.IconColor = Tema.Texto;
                botonActivo.Font = new Font(botonActivo.Font, FontStyle.Regular);
                botonActivo = null;
            }
            pnlIndicador.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuColapsado = !menuColapsado;
            int ancho = menuColapsado ? AnchoMenuColapsado : AnchoMenuExpandido;

            pnlMenuLateral.Width = ancho;
            pnlMarca.Width = ancho;
            pictureBoxLogo.Visible = !menuColapsado;
            lblNombreSistema.Visible = !menuColapsado;
            lblNombreSistemaSub.Visible = !menuColapsado;
            lblVersion.Text = menuColapsado ? "v1.0" : "v1.0  ·  2026";
            iconFormularioActual.Left = ancho + 18;
            lblTituloFormulario.Left = ancho + 48;

            foreach (Control control in pnlBotonesMenu.Controls)
            {
                IconButton boton = control as IconButton;
                if (boton != null)
                {
                    boton.Text = menuColapsado ? string.Empty : "   " + Convert.ToString(boton.Tag);
                    boton.ImageAlign = menuColapsado ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
                    boton.Padding = menuColapsado ? new Padding(0) : new Padding(20, 0, 0, 0);
                }
                else if (control is Label)
                {
                    control.Visible = !menuColapsado;
                }
            }

            if (botonActivo != null) pnlIndicador.Top = botonActivo.Top;
        }

        #endregion

        #region Botones del menú (15 módulos)

        private void btnSucursales_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new SucursalesForm()); }
        private void btnUsuarios_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new UsuariosForm()); }
        private void btnTipoEmpleado_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new TipoEmpleadoForm()); }
        private void btnClientes_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new ClientesForm()); }
        private void btnProveedores_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new ProveedoresForm()); }
        private void btnCategorias_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new CategoriasForm()); }
        private void btnProductos_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new ProductosForm()); }
        private void btnInventario_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new InventarioForm()); }
        private void btnDetallesInventario_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new DetallesInventarioForm()); }
        private void btnCompras_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new ComprasForm()); }
        private void btnDetalleCompras_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new DetalleComprasForm()); }
        private void btnVentas_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new VentasForm()); }
        private void btnDetalleVenta_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new DetalleVentaForm()); }
        private void btnTraslados_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new TrasladosForm()); }
        private void btnDetalleTraslado_Click(object sender, EventArgs e) { MtdActivarBoton(sender); AbrirFormularioHijo(new DetalleTrasladoForm()); }

        /// <summary>Tarjetas de acceso rápido de la pantalla de inicio.</summary>
        private void TarjetaAcceso_Click(object sender, EventArgs e)
        {
            string destino = Convert.ToString(((Control)sender).Tag);
            switch (destino)
            {
                case "Ventas": btnVentas.PerformClick(); break;
                case "Compras": btnCompras.PerformClick(); break;
                case "Productos": btnProductos.PerformClick(); break;
                case "Inventario": btnInventario.PerformClick(); break;
            }
        }

        #endregion

        #region Encabezado: sesión y controles de ventana

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            SesionCerrada = true;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlEncabezado_DoubleClick(object sender, EventArgs e)
        {
            btnMaximizar.PerformClick();
        }

        #endregion
    }
}
