namespace FerreteriaSistema.Formularios
{
    partial class ProductosForm
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
            this.colCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.pagConsulta = new FerreteriaSistema.UI.Controles.Paginador();
            this.tabGestionar = new System.Windows.Forms.TabPage();
            this.pnlFormulario = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblSeccionDesc = new System.Windows.Forms.Label();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkEstado = new FerreteriaSistema.UI.Controles.InterruptorEstado();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cboUnidadMedida = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
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
            this.lblTitulo.Text = "Productos";
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
            this.lblSubtitulo.Text = "Catálogo de productos, unidades de medida y precios de venta.";
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
            this.txtBuscar.Placeholder = "Buscar producto por nombre, código o categoría...";
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
            this.tarjTotal.Icono = FontAwesome.Sharp.IconChar.Box;
            this.tarjTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tarjTotal.Name = "tarjTotal";
            this.tarjTotal.Size = new System.Drawing.Size(316, 60);
            this.tarjTotal.Titulo = "Total de productos:";
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
            this.tarjResumen.Titulo = "Productos inactivos:";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCodigoProducto, this.colNombreProducto, this.colCategoria, this.colUnidadMedida, this.colPrecio, this.colDescripcion, this.colEstado, this.colAcciones });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
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
            // colCodigoProducto
            // 
            this.colCodigoProducto.DataPropertyName = "CodigoProducto";
            this.colCodigoProducto.FillWeight = 45F;
            this.colCodigoProducto.HeaderText = "Código";
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.ReadOnly = true;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.DataPropertyName = "NombreProducto";
            this.colNombreProducto.FillWeight = 120F;
            this.colNombreProducto.HeaderText = "Producto";
            this.colNombreProducto.Name = "colNombreProducto";
            this.colNombreProducto.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.FillWeight = 80F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.DataPropertyName = "UnidadMedida";
            this.colUnidadMedida.FillWeight = 60F;
            this.colUnidadMedida.HeaderText = "Unidad";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.ReadOnly = true;
            // 
            // colPrecio
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "Q #,##0.00";
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.FillWeight = 60F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.FillWeight = 130F;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
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
            this.lblSeccion.Text = "Datos de el producto";
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
            this.tlpCampos.Controls.Add(this.lblCodigoProducto, 0, 0);
            this.tlpCampos.Controls.Add(this.txtCodigoProducto, 0, 1);
            this.tlpCampos.Controls.Add(this.lblEstado, 1, 0);
            this.tlpCampos.Controls.Add(this.chkEstado, 1, 1);
            this.tlpCampos.Controls.Add(this.lblNombreProducto, 0, 2);
            this.tlpCampos.Controls.Add(this.txtNombreProducto, 0, 3);
            this.tlpCampos.Controls.Add(this.lblCategoria, 1, 2);
            this.tlpCampos.Controls.Add(this.cboCategoria, 1, 3);
            this.tlpCampos.Controls.Add(this.lblUnidadMedida, 0, 4);
            this.tlpCampos.Controls.Add(this.cboUnidadMedida, 0, 5);
            this.tlpCampos.Controls.Add(this.lblPrecio, 1, 4);
            this.tlpCampos.Controls.Add(this.txtPrecio, 1, 5);
            this.tlpCampos.Controls.Add(this.lblDescripcion, 0, 6);
            this.tlpCampos.Controls.Add(this.txtDescripcion, 0, 7);
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
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpCampos.Size = new System.Drawing.Size(924, 338);
            this.tlpCampos.SetColumnSpan(this.lblDescripcion, 2);
            this.tlpCampos.SetColumnSpan(this.txtDescripcion, 2);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCodigoProducto.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(200, 26);
            this.lblCodigoProducto.Text = "Código";
            this.lblCodigoProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtCodigoProducto.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCodigoProducto.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCodigoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCodigoProducto.Placeholder = "Automático";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEstado.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 26);
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkEstado
            // 
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.ColorActivo = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.chkEstado.ColorInactivo = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.chkEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEstado.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkEstado.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(200, 40);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(200, 26);
            this.lblNombreProducto.Text = "Nombre del producto *";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtNombreProducto.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNombreProducto.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtNombreProducto.Placeholder = "Ej. Martillo de uña 16 oz";
            this.txtNombreProducto.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(200, 26);
            this.lblCategoria.Text = "Categoría *";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboCategoria.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboCategoria.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboCategoria.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.ItemHeight = 34;
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.TabIndex = 13;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(200, 26);
            this.lblUnidadMedida.Text = "Unidad de medida *";
            this.lblUnidadMedida.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboUnidadMedida.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cboUnidadMedida.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboUnidadMedida.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnidadMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.ItemHeight = 34;
            this.cboUnidadMedida.Items.AddRange(new object[] { "Unidad", "Caja", "Paquete", "Juego", "Libra", "Kilogramo", "Quintal", "Galón", "Litro", "Metro", "Pie", "Pulgada", "Rollo", "Bolsa", "Saco" });
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(200, 26);
            this.lblPrecio.Text = "Precio de venta (Q) *";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPrecio
            // 
            this.txtPrecio.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtPrecio.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPrecio.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtPrecio.Placeholder = "0.00";
            this.txtPrecio.SoloDecimales = true;
            this.txtPrecio.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(200, 26);
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtDescripcion.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtDescripcion.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtDescripcion.Placeholder = "Características, marca, medidas...";
            this.txtDescripcion.TabIndex = 16;
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
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosForm";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.Text = "Productos";
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.pnlEncabezadoForm);
            this.Load += new System.EventHandler(this.ProductosForm_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TabPage tabGestionar;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblSeccionDesc;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigoProducto;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCodigoProducto;
        private System.Windows.Forms.Label lblEstado;
        private FerreteriaSistema.UI.Controles.InterruptorEstado chkEstado;
        private System.Windows.Forms.Label lblNombreProducto;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboCategoria;
        private System.Windows.Forms.Label lblUnidadMedida;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboUnidadMedida;
        private System.Windows.Forms.Label lblPrecio;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtDescripcion;
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
