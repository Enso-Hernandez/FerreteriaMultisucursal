namespace FerreteriaSistema.Formularios
{
    partial class ClientesForm
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
            this.chpActivos = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.chpInactivos = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.tarjTotal = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjResumen = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjActualizacion = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.pnlEspacioResumen = new System.Windows.Forms.Panel();
            this.pnlTabla = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.pagConsulta = new FerreteriaSistema.UI.Controles.Paginador();
            this.tabGestionar = new System.Windows.Forms.TabPage();
            this.pnlFormulario = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblSeccionDesc = new System.Windows.Forms.Label();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.chkEstadoCliente = new FerreteriaSistema.UI.Controles.InterruptorEstado();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblDPICliente = new System.Windows.Forms.Label();
            this.txtDPICliente = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new FerreteriaSistema.UI.Controles.DateTimePickerOscuro();
            this.lblVenta = new System.Windows.Forms.Label();
            this.cboVenta = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
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
            this.pnlAcciones.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.pnlEspacioAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
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
            this.lblTitulo.Text = "Clientes";
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
            this.lblSubtitulo.Text = "Registra los clientes asociados a las ventas de la ferretería.";
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
            this.flpFiltros.Controls.Add(this.chpActivos);
            this.flpFiltros.Controls.Add(this.chpInactivos);
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
            // chpActivos
            // 
            this.chpActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chpActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpActivos.FlatAppearance.BorderSize = 0;
            this.chpActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpActivos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpActivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpActivos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpActivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpActivos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpActivos.Name = "chpActivos";
            this.chpActivos.Radio = 15;
            this.chpActivos.Size = new System.Drawing.Size(84, 30);
            this.chpActivos.TabIndex = 3;
            this.chpActivos.Text = "Activos";
            this.chpActivos.UseVisualStyleBackColor = false;
            // 
            // chpInactivos
            // 
            this.chpInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chpInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpInactivos.FlatAppearance.BorderSize = 0;
            this.chpInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpInactivos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpInactivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpInactivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpInactivos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chpInactivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpInactivos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpInactivos.Name = "chpInactivos";
            this.chpInactivos.Radio = 15;
            this.chpInactivos.Size = new System.Drawing.Size(100, 30);
            this.chpInactivos.TabIndex = 4;
            this.chpInactivos.Text = "Inactivos";
            this.chpInactivos.UseVisualStyleBackColor = false;
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
            this.txtBuscar.Placeholder = "Buscar cliente por nombre, apellido o DPI...";
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
            this.tarjTotal.Icono = FontAwesome.Sharp.IconChar.Users;
            this.tarjTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tarjTotal.Name = "tarjTotal";
            this.tarjTotal.Size = new System.Drawing.Size(316, 60);
            this.tarjTotal.Titulo = "Total de clientes:";
            this.tarjTotal.Valor = "0";
            // 
            // tarjResumen
            // 
            this.tarjResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tarjResumen.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.tarjResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjResumen.Icono = FontAwesome.Sharp.IconChar.TriangleExclamation;
            this.tarjResumen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tarjResumen.Name = "tarjResumen";
            this.tarjResumen.Size = new System.Drawing.Size(316, 60);
            this.tarjResumen.Titulo = "Clientes inactivos:";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCodigoCliente, this.colNombreCliente, this.colApellidoCliente, this.colDPICliente, this.colTelefonoCliente, this.colFechaNacimiento, this.colCodigoVenta, this.colEstadoCliente, this.colAcciones });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
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
            // colCodigoCliente
            // 
            this.colCodigoCliente.DataPropertyName = "CodigoCliente";
            this.colCodigoCliente.FillWeight = 40F;
            this.colCodigoCliente.HeaderText = "Código";
            this.colCodigoCliente.Name = "colCodigoCliente";
            this.colCodigoCliente.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.DataPropertyName = "NombreCliente";
            this.colNombreCliente.FillWeight = 90F;
            this.colNombreCliente.HeaderText = "Nombre";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.ReadOnly = true;
            // 
            // colApellidoCliente
            // 
            this.colApellidoCliente.DataPropertyName = "ApellidoCliente";
            this.colApellidoCliente.FillWeight = 90F;
            this.colApellidoCliente.HeaderText = "Apellido";
            this.colApellidoCliente.Name = "colApellidoCliente";
            this.colApellidoCliente.ReadOnly = true;
            // 
            // colDPICliente
            // 
            this.colDPICliente.DataPropertyName = "DPICliente";
            this.colDPICliente.FillWeight = 90F;
            this.colDPICliente.HeaderText = "DPI";
            this.colDPICliente.Name = "colDPICliente";
            this.colDPICliente.ReadOnly = true;
            // 
            // colTelefonoCliente
            // 
            this.colTelefonoCliente.DataPropertyName = "TelefonoCliente";
            this.colTelefonoCliente.FillWeight = 70F;
            this.colTelefonoCliente.HeaderText = "Teléfono";
            this.colTelefonoCliente.Name = "colTelefonoCliente";
            this.colTelefonoCliente.ReadOnly = true;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.colFechaNacimiento.FillWeight = 80F;
            this.colFechaNacimiento.HeaderText = "Nacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.ReadOnly = true;
            // 
            // colCodigoVenta
            // 
            this.colCodigoVenta.DataPropertyName = "CodigoVenta";
            this.colCodigoVenta.FillWeight = 50F;
            this.colCodigoVenta.HeaderText = "Venta";
            this.colCodigoVenta.Name = "colCodigoVenta";
            this.colCodigoVenta.ReadOnly = true;
            // 
            // colEstadoCliente
            // 
            this.colEstadoCliente.DataPropertyName = "EstadoCliente";
            this.colEstadoCliente.FillWeight = 50F;
            this.colEstadoCliente.HeaderText = "Estado";
            this.colEstadoCliente.Name = "colEstadoCliente";
            this.colEstadoCliente.ReadOnly = true;
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
            this.pnlFormulario.Controls.Add(this.tlpCampos);
            this.pnlFormulario.Controls.Add(this.lblSeccionDesc);
            this.pnlFormulario.Controls.Add(this.lblSeccion);
            this.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(28, 18, 28, 12);
            this.pnlFormulario.Radio = 12;
            this.pnlFormulario.Size = new System.Drawing.Size(980, 438);
            this.pnlFormulario.AutoScroll = true;
            // 
            // lblSeccion
            // 
            this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(924, 36);
            this.lblSeccion.Text = "Datos del cliente";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeccionDesc
            // 
            this.lblSeccionDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccionDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblSeccionDesc.Name = "lblSeccionDesc";
            this.lblSeccionDesc.Size = new System.Drawing.Size(924, 26);
            this.lblSeccionDesc.Text = "Los campos marcados con * son obligatorios.";
            this.lblSeccionDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tlpCampos
            // 
            this.tlpCampos.Controls.Add(this.lblCodigoCliente, 0, 0);
            this.tlpCampos.Controls.Add(this.txtCodigoCliente, 0, 1);
            this.tlpCampos.Controls.Add(this.lblEstadoCliente, 1, 0);
            this.tlpCampos.Controls.Add(this.chkEstadoCliente, 1, 1);
            this.tlpCampos.Controls.Add(this.lblNombreCliente, 0, 2);
            this.tlpCampos.Controls.Add(this.txtNombreCliente, 0, 3);
            this.tlpCampos.Controls.Add(this.lblApellidoCliente, 1, 2);
            this.tlpCampos.Controls.Add(this.txtApellidoCliente, 1, 3);
            this.tlpCampos.Controls.Add(this.lblDPICliente, 0, 4);
            this.tlpCampos.Controls.Add(this.txtDPICliente, 0, 5);
            this.tlpCampos.Controls.Add(this.lblTelefonoCliente, 1, 4);
            this.tlpCampos.Controls.Add(this.txtTelefonoCliente, 1, 5);
            this.tlpCampos.Controls.Add(this.lblFechaNacimiento, 0, 6);
            this.tlpCampos.Controls.Add(this.dtpFechaNacimiento, 0, 7);
            this.tlpCampos.Controls.Add(this.lblVenta, 1, 6);
            this.tlpCampos.Controls.Add(this.cboVenta, 1, 7);
            this.tlpCampos.AutoSize = true;
            this.tlpCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 8;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCampos.Size = new System.Drawing.Size(924, 304);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCodigoCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(200, 26);
            this.lblCodigoCliente.Text = "Código";
            this.lblCodigoCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtCodigoCliente.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCodigoCliente.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCodigoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCodigoCliente.Placeholder = "Automático";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.TabIndex = 10;
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEstadoCliente.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(200, 26);
            this.lblEstadoCliente.Text = "Estado";
            this.lblEstadoCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkEstadoCliente
            // 
            this.chkEstadoCliente.Checked = true;
            this.chkEstadoCliente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstadoCliente.ColorActivo = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.chkEstadoCliente.ColorInactivo = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.chkEstadoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEstadoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEstadoCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstadoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkEstadoCliente.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.chkEstadoCliente.Name = "chkEstadoCliente";
            this.chkEstadoCliente.Size = new System.Drawing.Size(200, 40);
            this.chkEstadoCliente.TabIndex = 11;
            this.chkEstadoCliente.Text = "Estado";
            this.chkEstadoCliente.UseVisualStyleBackColor = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(200, 26);
            this.lblNombreCliente.Text = "Nombre *";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtNombreCliente.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNombreCliente.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtNombreCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtNombreCliente.MaxLength = 45;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtNombreCliente.Placeholder = "Ej. Pedro";
            this.txtNombreCliente.TabIndex = 12;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(200, 26);
            this.lblApellidoCliente.Text = "Apellido *";
            this.lblApellidoCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtApellidoCliente.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtApellidoCliente.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtApellidoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.txtApellidoCliente.MaxLength = 45;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtApellidoCliente.Placeholder = "Ej. Hernández";
            this.txtApellidoCliente.TabIndex = 13;
            // 
            // lblDPICliente
            // 
            this.lblDPICliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDPICliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPICliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDPICliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblDPICliente.Name = "lblDPICliente";
            this.lblDPICliente.Size = new System.Drawing.Size(200, 26);
            this.lblDPICliente.Text = "DPI *";
            this.lblDPICliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDPICliente
            // 
            this.txtDPICliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtDPICliente.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtDPICliente.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDPICliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDPICliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPICliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDPICliente.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtDPICliente.MaxLength = 13;
            this.txtDPICliente.Name = "txtDPICliente";
            this.txtDPICliente.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtDPICliente.Placeholder = "13 dígitos";
            this.txtDPICliente.TabIndex = 14;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(200, 26);
            this.lblTelefonoCliente.Text = "Teléfono *";
            this.lblTelefonoCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtTelefonoCliente.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTelefonoCliente.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtTelefonoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.txtTelefonoCliente.MaxLength = 8;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtTelefonoCliente.Placeholder = "Ej. 55501234";
            this.txtTelefonoCliente.TabIndex = 15;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(200, 26);
            this.lblFechaNacimiento.Text = "Fecha de nacimiento *";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.dtpFechaNacimiento.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtpFechaNacimiento.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.dtpFechaNacimiento.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 40);
            this.dtpFechaNacimiento.TabIndex = 16;
            // 
            // lblVenta
            // 
            this.lblVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVenta.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(200, 26);
            this.lblVenta.Text = "Venta *";
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboVenta
            // 
            this.cboVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboVenta.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboVenta.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboVenta.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboVenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVenta.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboVenta.FormattingEnabled = true;
            this.cboVenta.ItemHeight = 34;
            this.cboVenta.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.cboVenta.Name = "cboVenta";
            this.cboVenta.TabIndex = 17;
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
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesForm";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.Text = "Clientes";
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.pnlEncabezadoForm);
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlEspacioAcciones.ResumeLayout(false);
            this.pnlEspacioAcciones.PerformLayout();
            this.flpAcciones.ResumeLayout(false);
            this.flpAcciones.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
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
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpActivos;
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpInactivos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCliente;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TabPage tabGestionar;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblSeccionDesc;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigoCliente;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCodigoCliente;
        private System.Windows.Forms.Label lblEstadoCliente;
        private FerreteriaSistema.UI.Controles.InterruptorEstado chkEstadoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtApellidoCliente;
        private System.Windows.Forms.Label lblDPICliente;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtDPICliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtTelefonoCliente;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private FerreteriaSistema.UI.Controles.DateTimePickerOscuro dtpFechaNacimiento;
        private System.Windows.Forms.Label lblVenta;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboVenta;
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
