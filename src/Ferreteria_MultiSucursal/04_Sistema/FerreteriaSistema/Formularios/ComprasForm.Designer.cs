namespace FerreteriaSistema.Formularios
{
    partial class ComprasForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezadoForm = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlPestanas = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.btnTabConsultar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnTabGestionar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnCerrar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.tabPrincipal = new FerreteriaSistema.UI.Controles.TabControlSinPestanas();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.pnlBusqueda = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.txtBuscar = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.pnlEspacioBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.pnlEspacioConsulta = new System.Windows.Forms.Panel();
            this.pnlFilaBuscar = new System.Windows.Forms.Panel();
            this.pnlEspacioFiltros = new System.Windows.Forms.Panel();
            this.flpFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.chpTodos = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.chpEsteMes = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.chpAnuladas = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.tarjTotal = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjResumen = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjActualizacion = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.pnlEspacioResumen = new System.Windows.Forms.Panel();
            this.pnlTabla = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colCodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.pagConsulta = new FerreteriaSistema.UI.Controles.Paginador();
            this.tabGestionar = new System.Windows.Forms.TabPage();
            this.pnlFormulario = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoCompra = new System.Windows.Forms.Label();
            this.txtCodigoCompra = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboProveedor = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cboSucursal = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new FerreteriaSistema.UI.Controles.DateTimePickerOscuro();
            this.lblSeccionDetalle = new System.Windows.Forms.Label();
            this.tlpDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.btnAgregarDetalle = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnQuitarDetalle = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.pnlDetalleTabla = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colDetProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnEditar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnGuardar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnEliminar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.btnCancelar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.pnlEspacioAcciones = new System.Windows.Forms.Panel();
            this.pnlEncabezadoForm.SuspendLayout();
            this.pnlPestanas.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlFilaBuscar.SuspendLayout();
            this.flpFiltros.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.pnlEspacioBuscar.SuspendLayout();
            this.pnlEspacioConsulta.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.tabGestionar.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.tlpDetalle.SuspendLayout();
            this.pnlDetalleTabla.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.pnlEspacioAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezadoForm
            // 
            this.pnlEncabezadoForm.Controls.Add(this.btnCerrar);
            this.pnlEncabezadoForm.Controls.Add(this.pnlPestanas);
            this.pnlEncabezadoForm.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezadoForm.Controls.Add(this.lblModo);
            this.pnlEncabezadoForm.Controls.Add(this.lblTitulo);
            this.pnlEncabezadoForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlEncabezadoForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoForm.Name = "pnlEncabezadoForm";
            this.pnlEncabezadoForm.Size = new System.Drawing.Size(988, 72);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-4, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Compras";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblModo.Location = new System.Drawing.Point(170, 14);
            this.lblModo.Name = "lblModo";
            this.lblModo.Text = "●  Consulta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 42);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Registra las compras a proveedores (maestro) y los productos adquiridos (detalle).";
            // 
            // pnlPestanas
            // 
            this.pnlPestanas.Controls.Add(this.btnTabGestionar);
            this.pnlPestanas.Controls.Add(this.btnTabConsultar);
            this.pnlPestanas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPestanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlPestanas.Location = new System.Drawing.Point(668, 12);
            this.pnlPestanas.Name = "pnlPestanas";
            this.pnlPestanas.Padding = new System.Windows.Forms.Padding(4);
            this.pnlPestanas.Radio = 10;
            this.pnlPestanas.Size = new System.Drawing.Size(268, 44);
            // 
            // btnTabConsultar
            // 
            this.btnTabConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTabConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabConsultar.FlatAppearance.BorderSize = 0;
            this.btnTabConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabConsultar.ForeColor = System.Drawing.Color.White;
            this.btnTabConsultar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnTabConsultar.IconColor = System.Drawing.Color.White;
            this.btnTabConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabConsultar.IconSize = 16;
            this.btnTabConsultar.Location = new System.Drawing.Point(4, 4);
            this.btnTabConsultar.Name = "btnTabConsultar";
            this.btnTabConsultar.Radio = 8;
            this.btnTabConsultar.Size = new System.Drawing.Size(128, 36);
            this.btnTabConsultar.Text = "Consultar";
            this.btnTabConsultar.UseVisualStyleBackColor = false;
            this.btnTabConsultar.Click += new System.EventHandler(this.btnTabConsultar_Click);
            // 
            // btnTabGestionar
            // 
            this.btnTabGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTabGestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabGestionar.FlatAppearance.BorderSize = 0;
            this.btnTabGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabGestionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabGestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnTabGestionar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnTabGestionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnTabGestionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabGestionar.IconSize = 16;
            this.btnTabGestionar.Location = new System.Drawing.Point(136, 4);
            this.btnTabGestionar.Name = "btnTabGestionar";
            this.btnTabGestionar.Radio = 8;
            this.btnTabGestionar.Size = new System.Drawing.Size(128, 36);
            this.btnTabGestionar.Text = "Gestionar";
            this.btnTabGestionar.UseVisualStyleBackColor = false;
            this.btnTabGestionar.Click += new System.EventHandler(this.btnTabGestionar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCerrar.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 18;
            this.btnCerrar.Location = new System.Drawing.Point(948, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Radio = 8;
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.Text = "";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabConsultar);
            this.tabPrincipal.Controls.Add(this.tabGestionar);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(24, 92);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(988, 544);
            this.tabPrincipal.TabIndex = 1;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.pnlTabla);
            this.tabConsultar.Controls.Add(this.pnlEspacioResumen);
            this.tabConsultar.Controls.Add(this.tlpResumen);
            this.tabConsultar.Controls.Add(this.pnlEspacioConsulta);
            this.tabConsultar.Controls.Add(this.pnlBusqueda);
            this.tabConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabConsultar.Location = new System.Drawing.Point(4, 26);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tabConsultar.Size = new System.Drawing.Size(980, 534);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = false;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.flpFiltros);
            this.pnlBusqueda.Controls.Add(this.pnlEspacioFiltros);
            this.pnlBusqueda.Controls.Add(this.pnlFilaBuscar);
            this.pnlBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.pnlBusqueda.Radio = 12;
            this.pnlBusqueda.Size = new System.Drawing.Size(980, 112);
            // 
            // pnlFilaBuscar
            // 
            this.pnlFilaBuscar.Controls.Add(this.btnBuscar);
            this.pnlFilaBuscar.Controls.Add(this.txtBuscar);
            this.pnlFilaBuscar.Controls.Add(this.pnlEspacioBuscar);
            this.pnlFilaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlFilaBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilaBuscar.Name = "pnlFilaBuscar";
            this.pnlFilaBuscar.Size = new System.Drawing.Size(952, 48);
            // 
            // pnlEspacioFiltros
            // 
            this.pnlEspacioFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlEspacioFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioFiltros.Name = "pnlEspacioFiltros";
            this.pnlEspacioFiltros.Size = new System.Drawing.Size(952, 8);
            // 
            // flpFiltros
            // 
            this.flpFiltros.Controls.Add(this.chpTodos);
            this.flpFiltros.Controls.Add(this.chpEsteMes);
            this.flpFiltros.Controls.Add(this.chpAnuladas);
            this.flpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.flpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFiltros.Name = "flpFiltros";
            this.flpFiltros.Size = new System.Drawing.Size(952, 32);
            this.flpFiltros.WrapContents = false;
            // 
            // chpTodos
            // 
            this.chpTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chpTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpTodos.FlatAppearance.BorderSize = 0;
            this.chpTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpTodos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpTodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpTodos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpTodos.Name = "chpTodos";
            this.chpTodos.Radio = 15;
            this.chpTodos.Size = new System.Drawing.Size(68, 30);
            this.chpTodos.TabIndex = 2;
            this.chpTodos.Text = "Todos";
            this.chpTodos.UseVisualStyleBackColor = false;
            // 
            // chpEsteMes
            // 
            this.chpEsteMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chpEsteMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpEsteMes.FlatAppearance.BorderSize = 0;
            this.chpEsteMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpEsteMes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpEsteMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpEsteMes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpEsteMes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpEsteMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpEsteMes.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpEsteMes.Name = "chpEsteMes";
            this.chpEsteMes.Radio = 15;
            this.chpEsteMes.Size = new System.Drawing.Size(92, 30);
            this.chpEsteMes.TabIndex = 3;
            this.chpEsteMes.Text = "Este mes";
            this.chpEsteMes.UseVisualStyleBackColor = false;
            // 
            // chpAnuladas
            // 
            this.chpAnuladas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chpAnuladas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpAnuladas.FlatAppearance.BorderSize = 0;
            this.chpAnuladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpAnuladas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpAnuladas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpAnuladas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpAnuladas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpAnuladas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpAnuladas.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpAnuladas.Name = "chpAnuladas";
            this.chpAnuladas.Radio = 15;
            this.chpAnuladas.Size = new System.Drawing.Size(92, 30);
            this.chpAnuladas.TabIndex = 4;
            this.chpAnuladas.Text = "Anuladas";
            this.chpAnuladas.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtBuscar.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtBuscar.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtBuscar.Placeholder = "Buscar compra por proveedor, sucursal o número...";
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Icono = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.txtBuscar.Resplandor = true;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // pnlEspacioBuscar
            // 
            this.pnlEspacioBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlEspacioBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEspacioBuscar.Name = "pnlEspacioBuscar";
            this.pnlEspacioBuscar.Size = new System.Drawing.Size(142, 48);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Radio = 8;
            this.btnBuscar.Location = new System.Drawing.Point(822, 3);
            this.btnBuscar.Size = new System.Drawing.Size(130, 42);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlEspacioConsulta
            // 
            this.pnlEspacioConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlEspacioConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioConsulta.Name = "pnlEspacioConsulta";
            this.pnlEspacioConsulta.Size = new System.Drawing.Size(980, 10);
            // 
            // tlpResumen
            // 
            this.tlpResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tlpResumen.ColumnCount = 3;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpResumen.Controls.Add(this.tarjTotal, 0, 0);
            this.tlpResumen.Controls.Add(this.tarjResumen, 1, 0);
            this.tlpResumen.Controls.Add(this.tarjActualizacion, 2, 0);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 1;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Size = new System.Drawing.Size(980, 60);
            // 
            // tarjTotal
            // 
            this.tarjTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tarjTotal.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tarjTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjTotal.Icono = FontAwesome.Sharp.IconChar.CartShopping;
            this.tarjTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tarjTotal.Name = "tarjTotal";
            this.tarjTotal.Size = new System.Drawing.Size(316, 60);
            this.tarjTotal.Titulo = "Total de compras:";
            this.tarjTotal.Valor = "0";
            // 
            // tarjResumen
            // 
            this.tarjResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tarjResumen.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tarjResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjResumen.Icono = FontAwesome.Sharp.IconChar.Coins;
            this.tarjResumen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tarjResumen.Name = "tarjResumen";
            this.tarjResumen.Size = new System.Drawing.Size(316, 60);
            this.tarjResumen.Titulo = "Total comprado:";
            this.tarjResumen.Valor = "0";
            // 
            // tarjActualizacion
            // 
            this.tarjActualizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tarjActualizacion.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tarjActualizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjActualizacion.Icono = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.tarjActualizacion.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tarjActualizacion.Name = "tarjActualizacion";
            this.tarjActualizacion.Size = new System.Drawing.Size(316, 60);
            this.tarjActualizacion.Titulo = "Última actualización:";
            this.tarjActualizacion.Valor = "0";
            // 
            // pnlEspacioResumen
            // 
            this.pnlEspacioResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlEspacioResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioResumen.Name = "pnlEspacioResumen";
            this.pnlEspacioResumen.Size = new System.Drawing.Size(980, 10);
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.dgvDatos);
            this.pnlTabla.Controls.Add(this.pnlPie);
            this.pnlTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.pnlTabla.Radio = 12;
            this.pnlTabla.Size = new System.Drawing.Size(980, 400);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCodigoCompra, this.colProveedor, this.colSucursal, this.colFecha, this.colTotal, this.colEstado, this.colAcciones });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 40;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            this.dgvDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDatos_DataBindingComplete);
            this.dgvDatos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDatos_RowsAdded);
            this.dgvDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDatos_RowsRemoved);
            // 
            // colCodigoCompra
            // 
            this.colCodigoCompra.DataPropertyName = "CodigoCompra";
            this.colCodigoCompra.FillWeight = 50F;
            this.colCodigoCompra.HeaderText = "No. compra";
            this.colCodigoCompra.Name = "colCodigoCompra";
            this.colCodigoCompra.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "Proveedor";
            this.colProveedor.FillWeight = 120F;
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colSucursal
            // 
            this.colSucursal.DataPropertyName = "Sucursal";
            this.colSucursal.FillWeight = 100F;
            this.colSucursal.HeaderText = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.ReadOnly = true;
            // 
            // colFecha
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.FillWeight = 60F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "Q #,##0.00";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.FillWeight = 60F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.FillWeight = 50F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colAcciones
            // 
            this.colAcciones.FillWeight = 120F;
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(596, 34);
            this.lblRegistros.Text = "0 registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPie
            // 
            this.pnlPie.Controls.Add(this.lblRegistros);
            this.pnlPie.Controls.Add(this.pagConsulta);
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(956, 34);
            // 
            // pagConsulta
            // 
            this.pagConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pagConsulta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.pagConsulta.Name = "pagConsulta";
            this.pagConsulta.Size = new System.Drawing.Size(360, 34);
            // 
            // tabGestionar
            // 
            this.tabGestionar.Controls.Add(this.pnlFormulario);
            this.tabGestionar.Controls.Add(this.pnlEspacioAcciones);
            this.tabGestionar.Controls.Add(this.pnlAcciones);
            this.tabGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabGestionar.Location = new System.Drawing.Point(4, 26);
            this.tabGestionar.Name = "tabGestionar";
            this.tabGestionar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tabGestionar.Size = new System.Drawing.Size(980, 534);
            this.tabGestionar.TabIndex = 1;
            this.tabGestionar.Text = "Gestionar";
            this.tabGestionar.UseVisualStyleBackColor = false;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.pnlDetalleTabla);
            this.pnlFormulario.Controls.Add(this.pnlTotal);
            this.pnlFormulario.Controls.Add(this.tlpDetalle);
            this.pnlFormulario.Controls.Add(this.lblSeccionDetalle);
            this.pnlFormulario.Controls.Add(this.tlpCampos);
            this.pnlFormulario.Controls.Add(this.lblSeccion);
            this.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(24, 14, 24, 12);
            this.pnlFormulario.Radio = 12;
            this.pnlFormulario.Size = new System.Drawing.Size(980, 438);
            // 
            // lblSeccion
            // 
            this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(932, 32);
            this.lblSeccion.Text = "Datos de la compra";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpCampos
            // 
            this.tlpCampos.Controls.Add(this.lblCodigoCompra, 0, 0);
            this.tlpCampos.Controls.Add(this.txtCodigoCompra, 0, 1);
            this.tlpCampos.Controls.Add(this.lblProveedor, 1, 0);
            this.tlpCampos.Controls.Add(this.cboProveedor, 1, 1);
            this.tlpCampos.Controls.Add(this.lblSucursal, 2, 0);
            this.tlpCampos.Controls.Add(this.cboSucursal, 2, 1);
            this.tlpCampos.Controls.Add(this.lblFecha, 3, 0);
            this.tlpCampos.Controls.Add(this.dtpFecha, 3, 1);
            this.tlpCampos.AutoSize = true;
            this.tlpCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tlpCampos.ColumnCount = 4;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 2;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCampos.Size = new System.Drawing.Size(932, 76);
            // 
            // lblCodigoCompra
            // 
            this.lblCodigoCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCodigoCompra.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblCodigoCompra.Name = "lblCodigoCompra";
            this.lblCodigoCompra.Size = new System.Drawing.Size(200, 26);
            this.lblCodigoCompra.Text = "No. compra";
            this.lblCodigoCompra.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtCodigoCompra.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCodigoCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCodigoCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoCompra.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCompra.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCodigoCompra.Placeholder = "Automático";
            this.txtCodigoCompra.ReadOnly = true;
            this.txtCodigoCompra.TabIndex = 10;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(200, 26);
            this.lblProveedor.Text = "Proveedor *";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboProveedor
            // 
            this.cboProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboProveedor.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboProveedor.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboProveedor.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.ItemHeight = 34;
            this.cboProveedor.Margin = new System.Windows.Forms.Padding(10, 2, 10, 8);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.TabIndex = 11;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSucursal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(200, 26);
            this.lblSucursal.Text = "Sucursal *";
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboSucursal
            // 
            this.cboSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboSucursal.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboSucursal.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboSucursal.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.ItemHeight = 34;
            this.cboSucursal.Margin = new System.Windows.Forms.Padding(10, 2, 10, 8);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFecha.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(200, 26);
            this.lblFecha.Text = "Fecha *";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFecha
            // 
            this.dtpFecha.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.dtpFecha.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtpFecha.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 40);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblSeccionDetalle
            // 
            this.lblSeccionDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccionDetalle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionDetalle.ForeColor = System.Drawing.Color.White;
            this.lblSeccionDetalle.Name = "lblSeccionDetalle";
            this.lblSeccionDetalle.Size = new System.Drawing.Size(932, 40);
            this.lblSeccionDetalle.Text = "Detalle de productos";
            this.lblSeccionDetalle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tlpDetalle
            // 
            this.tlpDetalle.Controls.Add(this.lblProducto, 0, 0);
            this.tlpDetalle.Controls.Add(this.cboProducto, 0, 1);
            this.tlpDetalle.Controls.Add(this.lblCantidad, 1, 0);
            this.tlpDetalle.Controls.Add(this.txtCantidad, 1, 1);
            this.tlpDetalle.Controls.Add(this.lblCosto, 2, 0);
            this.tlpDetalle.Controls.Add(this.txtCosto, 2, 1);
            this.tlpDetalle.Controls.Add(this.btnAgregarDetalle, 3, 1);
            this.tlpDetalle.Controls.Add(this.btnQuitarDetalle, 4, 1);
            this.tlpDetalle.AutoSize = true;
            this.tlpDetalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tlpDetalle.ColumnCount = 5;
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDetalle.Name = "tlpDetalle";
            this.tlpDetalle.RowCount = 2;
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDetalle.Size = new System.Drawing.Size(932, 76);
            // 
            // lblProducto
            // 
            this.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblProducto.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(150, 26);
            this.lblProducto.Text = "Producto *";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboProducto
            // 
            this.cboProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboProducto.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboProducto.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboProducto.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProducto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.ItemHeight = 34;
            this.cboProducto.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.TabIndex = 20;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(150, 26);
            this.lblCantidad.Text = "Cantidad *";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtCantidad.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCantidad.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(10, 2, 10, 8);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCantidad.Placeholder = "0";
            this.txtCantidad.SoloDecimales = true;
            this.txtCantidad.TabIndex = 21;
            // 
            // lblCosto
            // 
            this.lblCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCosto.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(150, 26);
            this.lblCosto.Text = "Costo unitario (Q) *";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCosto
            // 
            this.txtCosto.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtCosto.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCosto.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCosto.Margin = new System.Windows.Forms.Padding(10, 2, 10, 8);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCosto.Placeholder = "0.00";
            this.txtCosto.SoloDecimales = true;
            this.txtCosto.TabIndex = 22;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarDetalle.IconColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDetalle.IconSize = 16;
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(10, 2, 5, 8);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Radio = 8;
            this.btnAgregarDetalle.Size = new System.Drawing.Size(120, 40);
            this.btnAgregarDetalle.TabIndex = 23;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnQuitarDetalle
            // 
            this.btnQuitarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnQuitarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitarDetalle.FlatAppearance.BorderSize = 0;
            this.btnQuitarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnQuitarDetalle.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnQuitarDetalle.IconColor = System.Drawing.Color.White;
            this.btnQuitarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitarDetalle.IconSize = 16;
            this.btnQuitarDetalle.Margin = new System.Windows.Forms.Padding(5, 2, 0, 8);
            this.btnQuitarDetalle.Name = "btnQuitarDetalle";
            this.btnQuitarDetalle.Radio = 8;
            this.btnQuitarDetalle.Size = new System.Drawing.Size(120, 40);
            this.btnQuitarDetalle.TabIndex = 24;
            this.btnQuitarDetalle.Text = "Quitar";
            this.btnQuitarDetalle.UseVisualStyleBackColor = false;
            this.btnQuitarDetalle.Click += new System.EventHandler(this.btnQuitarDetalle_Click);
            // 
            // pnlDetalleTabla
            // 
            this.pnlDetalleTabla.Controls.Add(this.dgvDetalle);
            this.pnlDetalleTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlDetalleTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleTabla.Name = "pnlDetalleTabla";
            this.pnlDetalleTabla.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlDetalleTabla.Size = new System.Drawing.Size(932, 120);
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalle.ColumnHeadersHeight = 44;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDetProducto, this.colDetCantidad, this.colDetCosto, this.colDetSubtotal });
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 38;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.TabStop = false;
            // 
            // colDetProducto
            // 
            this.colDetProducto.FillWeight = 180F;
            this.colDetProducto.HeaderText = "Producto";
            this.colDetProducto.Name = "colDetProducto";
            this.colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0.##";
            this.colDetCantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDetCantidad.FillWeight = 60F;
            this.colDetCantidad.HeaderText = "Cantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.ReadOnly = true;
            // 
            // colDetCosto
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "Q #,##0.00";
            this.colDetCosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDetCosto.FillWeight = 70F;
            this.colDetCosto.HeaderText = "Costo unitario";
            this.colDetCosto.Name = "colDetCosto";
            this.colDetCosto.ReadOnly = true;
            // 
            // colDetSubtotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "Q #,##0.00";
            this.colDetSubtotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDetSubtotal.FillWeight = 70F;
            this.colDetSubtotal.HeaderText = "Subtotal";
            this.colDetSubtotal.Name = "colDetSubtotal";
            this.colDetSubtotal.ReadOnly = true;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotalTitulo);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(932, 44);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 44);
            this.lblTotal.Text = "Q 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(200, 44);
            this.lblTotalTitulo.Text = "TOTAL DE LA COMPRA";
            this.lblTotalTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.flpAcciones);
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.pnlAcciones.Radio = 12;
            this.pnlAcciones.Size = new System.Drawing.Size(980, 68);
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Controls.Add(this.btnEditar);
            this.flpAcciones.Controls.Add(this.btnGuardar);
            this.flpAcciones.Controls.Add(this.btnEliminar);
            this.flpAcciones.Controls.Add(this.btnCancelar);
            this.flpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Size = new System.Drawing.Size(952, 44);
            this.flpAcciones.WrapContents = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 18;
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Radio = 8;
            this.btnNuevo.Size = new System.Drawing.Size(132, 44);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 18;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Radio = 8;
            this.btnEditar.Size = new System.Drawing.Size(132, 44);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 18;
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Radio = 8;
            this.btnGuardar.Size = new System.Drawing.Size(132, 44);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 18;
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radio = 8;
            this.btnEliminar.Size = new System.Drawing.Size(132, 44);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 18;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Radio = 8;
            this.btnCancelar.Size = new System.Drawing.Size(132, 44);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlEspacioAcciones
            // 
            this.pnlEspacioAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlEspacioAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEspacioAcciones.Name = "pnlEspacioAcciones";
            this.pnlEspacioAcciones.Size = new System.Drawing.Size(980, 14);
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasForm";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.Text = "Compras";
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.pnlEncabezadoForm);
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlEspacioAcciones.ResumeLayout(false);
            this.pnlEspacioAcciones.PerformLayout();
            this.flpAcciones.ResumeLayout(false);
            this.flpAcciones.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlDetalleTabla.ResumeLayout(false);
            this.pnlDetalleTabla.PerformLayout();
            this.tlpDetalle.ResumeLayout(false);
            this.tlpDetalle.PerformLayout();
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.tabGestionar.ResumeLayout(false);
            this.tabGestionar.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            this.pnlTabla.PerformLayout();
            this.pnlEspacioConsulta.ResumeLayout(false);
            this.pnlEspacioConsulta.PerformLayout();
            this.pnlEspacioBuscar.ResumeLayout(false);
            this.pnlEspacioBuscar.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.tlpResumen.ResumeLayout(false);
            this.flpFiltros.ResumeLayout(false);
            this.pnlFilaBuscar.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.pnlPestanas.ResumeLayout(false);
            this.pnlPestanas.PerformLayout();
            this.pnlEncabezadoForm.ResumeLayout(false);
            this.pnlEncabezadoForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezadoForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblSubtitulo;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlPestanas;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnTabConsultar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnTabGestionar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnCerrar;
        private FerreteriaSistema.UI.Controles.TabControlSinPestanas tabPrincipal;
        private System.Windows.Forms.TabPage tabConsultar;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlBusqueda;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtBuscar;
        private System.Windows.Forms.Panel pnlEspacioBuscar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnBuscar;
        private System.Windows.Forms.Panel pnlEspacioConsulta;
        private System.Windows.Forms.Panel pnlFilaBuscar;
        private System.Windows.Forms.Panel pnlEspacioFiltros;
        private System.Windows.Forms.FlowLayoutPanel flpFiltros;
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpTodos;
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpEsteMes;
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpAnuladas;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private FerreteriaSistema.UI.Controles.TarjetaResumen tarjTotal;
        private FerreteriaSistema.UI.Controles.TarjetaResumen tarjResumen;
        private FerreteriaSistema.UI.Controles.TarjetaResumen tarjActualizacion;
        private System.Windows.Forms.Panel pnlEspacioResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcciones;
        private System.Windows.Forms.Panel pnlPie;
        private FerreteriaSistema.UI.Controles.Paginador pagConsulta;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlTabla;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TabPage tabGestionar;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigoCompra;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCodigoCompra;
        private System.Windows.Forms.Label lblProveedor;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboProveedor;
        private System.Windows.Forms.Label lblSucursal;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboSucursal;
        private System.Windows.Forms.Label lblFecha;
        private FerreteriaSistema.UI.Controles.DateTimePickerOscuro dtpFecha;
        private System.Windows.Forms.Label lblSeccionDetalle;
        private System.Windows.Forms.TableLayoutPanel tlpDetalle;
        private System.Windows.Forms.Label lblProducto;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboProducto;
        private System.Windows.Forms.Label lblCantidad;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCantidad;
        private System.Windows.Forms.Label lblCosto;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCosto;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnAgregarDetalle;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnQuitarDetalle;
        private System.Windows.Forms.Panel pnlDetalleTabla;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetSubtotal;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTitulo;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlAcciones;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnNuevo;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnEditar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnGuardar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnEliminar;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnCancelar;
        private System.Windows.Forms.Panel pnlEspacioAcciones;
    }
}
