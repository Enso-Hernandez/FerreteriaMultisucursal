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
        private const int AnchoMenuExpandido = 280;
        private const int AnchoMenuColapsado = 100;

        private readonly string nombreUsuario;
        private readonly string nombreSucursal;
        private IconButton botonActivo;
        private Form formularioActivo;
        private bool menuColapsado = true;   // el menú empieza solo con íconos

        /// <summary>Indica si el usuario cerró sesión (para volver al Login) o cerró la aplicación.</summary>
        public bool SesionCerrada { get; private set; }

        // Constructor vacío requerido por el Diseñador de Visual Studio.
        public DashboardForm() : this("Administrador", "Sucursal Central")
        {
        }

        public DashboardForm(string usuario, string sucursal)
        {
            InitializeComponent();
            Tema.AplicarFondo(this);
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
            Tema.HabilitarArrastre(this, pnlEncabezado, lblTituloFormulario, iconFormularioActual);

            // Al desplazar el menú se repinta todo para que el vidrio quede bien detrás de los botones.
            pnlBotonesMenu.Scroll += (s, ev) => pnlBotonesMenu.Invalidate(true);
            pnlBotonesMenu.MouseWheel += (s, ev) => pnlBotonesMenu.Invalidate(true);
            MtdAplicarMenu();

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
        /// Tema.AplicarFondo le pone el fondo degradado y vuelve transparentes sus paneles.
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
            Tema.AplicarFondo(formularioHijo);

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
            botonActivo.BackColor = Tema.VidrioClaro;      // resaltado de vidrio
            botonActivo.ForeColor = Color.White;
            botonActivo.IconColor = Color.White;
            botonActivo.Font = new Font(botonActivo.Font, FontStyle.Bold);

            iconFormularioActual.IconChar = botonActivo.IconChar;
        }

        private void MtdDesactivarBoton()
        {
            if (botonActivo == null) return;
            botonActivo.BackColor = Color.Transparent;
            botonActivo.ForeColor = Tema.Texto;
            botonActivo.IconColor = Tema.TextoSecundario;
            botonActivo.Font = new Font(botonActivo.Font, FontStyle.Regular);
            botonActivo = null;
        }

        /// <summary>El botón ☰ y el logo abren o cierran el menú lateral.</summary>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuColapsado = !menuColapsado;
            MtdAplicarMenu();
        }

        /// <summary>Menú expandido (íconos y nombres) o colapsado (solo íconos, el nombre aparece al pasar el mouse).</summary>
        private void MtdAplicarMenu()
        {
            pnlMenuLateral.Width = MtdEscalar(menuColapsado ? AnchoMenuColapsado : AnchoMenuExpandido);
            lblNombreSistema.Visible = !menuColapsado;
            lblNombreSistemaSub.Visible = !menuColapsado;
            lblVersion.Text = menuColapsado ? "v1.0" : "v1.0  ·  2026";

            foreach (Control control in pnlBotonesMenu.Controls)
            {
                IconButton boton = control as IconButton;
                if (boton != null)
                {
                    // Colapsado: botones más altos e íconos más grandes (no hay títulos de sección).
                    boton.Text = menuColapsado ? string.Empty : "   " + Convert.ToString(boton.Tag);
                    boton.TextAlign = menuColapsado ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
                    boton.Height = MtdEscalar(menuColapsado ? 40 : 36);
                    boton.IconSize = menuColapsado ? 21 : 19;
                }
                else if (control is Label)
                {
                    control.Visible = !menuColapsado;
                }
            }

            ttMenu.Active = menuColapsado;   // los nombres flotantes solo hacen falta con el menú colapsado
            Invalidate(true);                // el contenido se movió: se repinta el fondo degradado
        }

        /// <summary>
        /// Ajusta un tamaño en píxeles a la escala de pantalla de Windows (100 %, 125 %...).
        /// El Diseñador está hecho a 96 DPI y Windows Forms lo escala solo; los tamaños
        /// escritos en el código se escalan aquí con la misma proporción.
        /// </summary>
        private int MtdEscalar(int pixeles)
        {
            return (int)Math.Round(pixeles * CurrentAutoScaleDimensions.Width / 96f);
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
