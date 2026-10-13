namespace FerreteriaSistema.Formularios
{
    partial class DetallesInventarioForm
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
            this.lblTitulo = new FerreteriaSistema.UI.Controles.EtiquetaDegradado();
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
            this.chpEntradas = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.chpSalidas = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.tarjTotal = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjResumen = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.tarjActualizacion = new FerreteriaSistema.UI.Controles.TarjetaResumen();
            this.pnlEspacioResumen = new System.Windows.Forms.Panel();
            this.pnlTabla = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colCodigoDetalleInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.pagConsulta = new FerreteriaSistema.UI.Controles.Paginador();
            this.tabGestionar = new System.Windows.Forms.TabPage();
            this.pnlFormulario = new FerreteriaSistema.UI.Controles.PanelRedondeado();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblSeccionDesc = new System.Windows.Forms.Label();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoDetalleInventario = new System.Windows.Forms.Label();
            this.txtCodigoDetalleInventario = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblInventario = new System.Windows.Forms.Label();
            this.cboInventario = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.cboTipoMovimiento = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblFechaMovimiento = new System.Windows.Forms.Label();
            this.dtpFechaMovimiento = new FerreteriaSistema.UI.Controles.DateTimePickerOscuro();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.txtEgreso = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
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
            this.pnlEncabezadoForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
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
            this.lblTitulo.Text = "Detalle de inventario";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.lblModo.Location = new System.Drawing.Point(170, 14);
            this.lblModo.Name = "lblModo";
            this.lblModo.Text = "●  Consulta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 42);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Registra las entradas y salidas de cada inventario.";
            // 
            // pnlPestanas
            // 
            this.pnlPestanas.Controls.Add(this.btnTabGestionar);
            this.pnlPestanas.Controls.Add(this.btnTabConsultar);
            this.pnlPestanas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPestanas.ColorRelleno = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.pnlPestanas.Location = new System.Drawing.Point(668, 12);
            this.pnlPestanas.Name = "pnlPestanas";
            this.pnlPestanas.Padding = new System.Windows.Forms.Padding(4);
            this.pnlPestanas.Radio = 10;
            this.pnlPestanas.Size = new System.Drawing.Size(268, 44);
            // 
            // btnTabConsultar
            // 
            this.btnTabConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
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
            this.btnTabGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnTabGestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabGestionar.FlatAppearance.BorderSize = 0;
            this.btnTabGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabGestionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabGestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.btnTabGestionar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnTabGestionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
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
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
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
            this.tabConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
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
            this.pnlBusqueda.ColorRelleno = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.pnlFilaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pnlFilaBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilaBuscar.Name = "pnlFilaBuscar";
            this.pnlFilaBuscar.Size = new System.Drawing.Size(952, 48);
            // 
            // pnlEspacioFiltros
            // 
            this.pnlEspacioFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pnlEspacioFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioFiltros.Name = "pnlEspacioFiltros";
            this.pnlEspacioFiltros.Size = new System.Drawing.Size(952, 8);
            // 
            // flpFiltros
            // 
            this.flpFiltros.Controls.Add(this.chpTodos);
            this.flpFiltros.Controls.Add(this.chpEntradas);
            this.flpFiltros.Controls.Add(this.chpSalidas);
            this.flpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.flpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFiltros.Name = "flpFiltros";
            this.flpFiltros.Size = new System.Drawing.Size(952, 32);
            this.flpFiltros.WrapContents = false;
            // 
            // chpTodos
            // 
            this.chpTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.chpTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpTodos.FlatAppearance.BorderSize = 0;
            this.chpTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpTodos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpTodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpTodos.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpTodos.Name = "chpTodos";
            this.chpTodos.Radio = 15;
            this.chpTodos.Size = new System.Drawing.Size(68, 30);
            this.chpTodos.TabIndex = 2;
            this.chpTodos.Text = "Todos";
            this.chpTodos.UseVisualStyleBackColor = false;
            // 
            // chpEntradas
            // 
            this.chpEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.chpEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpEntradas.FlatAppearance.BorderSize = 0;
            this.chpEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpEntradas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpEntradas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpEntradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpEntradas.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpEntradas.Name = "chpEntradas";
            this.chpEntradas.Radio = 15;
            this.chpEntradas.Size = new System.Drawing.Size(92, 30);
            this.chpEntradas.TabIndex = 3;
            this.chpEntradas.Text = "Entradas";
            this.chpEntradas.UseVisualStyleBackColor = false;
            // 
            // chpSalidas
            // 
            this.chpSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.chpSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chpSalidas.FlatAppearance.BorderSize = 0;
            this.chpSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpSalidas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpSalidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.chpSalidas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.chpSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chpSalidas.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.chpSalidas.Name = "chpSalidas";
            this.chpSalidas.Radio = 15;
            this.chpSalidas.Size = new System.Drawing.Size(84, 30);
            this.chpSalidas.TabIndex = 4;
            this.chpSalidas.Text = "Salidas";
            this.chpSalidas.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtBuscar.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtBuscar.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtBuscar.Placeholder = "Buscar movimiento por descripción o tipo...";
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Icono = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.txtBuscar.Resplandor = true;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // pnlEspacioBuscar
            // 
            this.pnlEspacioBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pnlEspacioBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEspacioBuscar.Name = "pnlEspacioBuscar";
            this.pnlEspacioBuscar.Size = new System.Drawing.Size(142, 48);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
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
            this.pnlEspacioConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.pnlEspacioConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioConsulta.Name = "pnlEspacioConsulta";
            this.pnlEspacioConsulta.Size = new System.Drawing.Size(980, 10);
            // 
            // tlpResumen
            // 
            this.tlpResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
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
            this.tarjTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tarjTotal.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.tarjTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjTotal.Icono = FontAwesome.Sharp.IconChar.ArrowRightArrowLeft;
            this.tarjTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tarjTotal.Name = "tarjTotal";
            this.tarjTotal.Size = new System.Drawing.Size(316, 60);
            this.tarjTotal.Titulo = "Total de movimientos:";
            this.tarjTotal.Valor = "0";
            // 
            // tarjResumen
            // 
            this.tarjResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tarjResumen.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.tarjResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarjResumen.Icono = FontAwesome.Sharp.IconChar.TruckFast;
            this.tarjResumen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tarjResumen.Name = "tarjResumen";
            this.tarjResumen.Size = new System.Drawing.Size(316, 60);
            this.tarjResumen.Titulo = "Salidas registradas:";
            this.tarjResumen.Valor = "0";
            // 
            // tarjActualizacion
            // 
            this.tarjActualizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tarjActualizacion.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(238)))));
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
            this.pnlEspacioResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.pnlEspacioResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacioResumen.Name = "pnlEspacioResumen";
            this.pnlEspacioResumen.Size = new System.Drawing.Size(980, 10);
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.dgvDatos);
            this.pnlTabla.Controls.Add(this.pnlPie);
            this.pnlTabla.ColorRelleno = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.pnlTabla.Radio = 12;
            this.pnlTabla.Size = new System.Drawing.Size(980, 400);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 40;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCodigoDetalleInventario, this.colCodigoInventario, this.colTipoMovimiento, this.colFechaMovimiento, this.colIngreso, this.colEgreso, this.colDescripcion, this.colAcciones });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
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
            // colCodigoDetalleInventario
            // 
            this.colCodigoDetalleInventario.DataPropertyName = "CodigoDetalleInventario";
            this.colCodigoDetalleInventario.FillWeight = 40F;
            this.colCodigoDetalleInventario.HeaderText = "Código";
            this.colCodigoDetalleInventario.Name = "colCodigoDetalleInventario";
            this.colCodigoDetalleInventario.ReadOnly = true;
            // 
            // colCodigoInventario
            // 
            this.colCodigoInventario.DataPropertyName = "CodigoInventario";
            this.colCodigoInventario.FillWeight = 60F;
            this.colCodigoInventario.HeaderText = "Inventario";
            this.colCodigoInventario.Name = "colCodigoInventario";
            this.colCodigoInventario.ReadOnly = true;
            // 
            // colTipoMovimiento
            // 
            this.colTipoMovimiento.DataPropertyName = "TipoMovimiento";
            this.colTipoMovimiento.FillWeight = 60F;
            this.colTipoMovimiento.HeaderText = "Tipo";
            this.colTipoMovimiento.Name = "colTipoMovimiento";
            this.colTipoMovimiento.ReadOnly = true;
            // 
            // colFechaMovimiento
            // 
            this.colFechaMovimiento.DataPropertyName = "FechaMovimiento";
            this.colFechaMovimiento.FillWeight = 70F;
            this.colFechaMovimiento.HeaderText = "Fecha";
            this.colFechaMovimiento.Name = "colFechaMovimiento";
            this.colFechaMovimiento.ReadOnly = true;
            // 
            // colIngreso
            // 
            this.colIngreso.DataPropertyName = "Ingreso";
            this.colIngreso.FillWeight = 50F;
            this.colIngreso.HeaderText = "Ingreso";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            // 
            // colEgreso
            // 
            this.colEgreso.DataPropertyName = "Egreso";
            this.colEgreso.FillWeight = 50F;
            this.colEgreso.HeaderText = "Egreso";
            this.colEgreso.Name = "colEgreso";
            this.colEgreso.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.FillWeight = 150F;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
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
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(596, 34);
            this.lblRegistros.Text = "0 registros";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPie
            // 
            this.pnlPie.Controls.Add(this.lblRegistros);
            this.pnlPie.Controls.Add(this.pagConsulta);
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(956, 34);
            // 
            // pagConsulta
            // 
            this.pagConsulta.BackColor = System.Drawing.Color.Transparent;
            this.pagConsulta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pagConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.pagConsulta.Name = "pagConsulta";
            this.pagConsulta.Size = new System.Drawing.Size(360, 34);
            // 
            // tabGestionar
            // 
            this.tabGestionar.Controls.Add(this.pnlFormulario);
            this.tabGestionar.Controls.Add(this.pnlEspacioAcciones);
            this.tabGestionar.Controls.Add(this.pnlAcciones);
            this.tabGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
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
            this.pnlFormulario.ColorRelleno = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.lblSeccion.Text = "Datos del movimiento";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeccionDesc
            // 
            this.lblSeccionDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccionDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.lblSeccionDesc.Name = "lblSeccionDesc";
            this.lblSeccionDesc.Size = new System.Drawing.Size(924, 26);
            this.lblSeccionDesc.Text = "Los campos marcados con * son obligatorios.";
            this.lblSeccionDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tlpCampos
            // 
            this.tlpCampos.Controls.Add(this.lblCodigoDetalleInventario, 0, 0);
            this.tlpCampos.Controls.Add(this.txtCodigoDetalleInventario, 0, 1);
            this.tlpCampos.Controls.Add(this.lblInventario, 1, 0);
            this.tlpCampos.Controls.Add(this.cboInventario, 1, 1);
            this.tlpCampos.Controls.Add(this.lblTipoMovimiento, 0, 2);
            this.tlpCampos.Controls.Add(this.cboTipoMovimiento, 0, 3);
            this.tlpCampos.Controls.Add(this.lblFechaMovimiento, 1, 2);
            this.tlpCampos.Controls.Add(this.dtpFechaMovimiento, 1, 3);
            this.tlpCampos.Controls.Add(this.lblIngreso, 0, 4);
            this.tlpCampos.Controls.Add(this.txtIngreso, 0, 5);
            this.tlpCampos.Controls.Add(this.lblEgreso, 1, 4);
            this.tlpCampos.Controls.Add(this.txtEgreso, 1, 5);
            this.tlpCampos.Controls.Add(this.lblDescripcion, 0, 6);
            this.tlpCampos.Controls.Add(this.txtDescripcion, 0, 7);
            this.tlpCampos.AutoSize = true;
            this.tlpCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
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
            // lblCodigoDetalleInventario
            // 
            this.lblCodigoDetalleInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoDetalleInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalleInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblCodigoDetalleInventario.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblCodigoDetalleInventario.Name = "lblCodigoDetalleInventario";
            this.lblCodigoDetalleInventario.Size = new System.Drawing.Size(200, 26);
            this.lblCodigoDetalleInventario.Text = "Código";
            this.lblCodigoDetalleInventario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodigoDetalleInventario
            // 
            this.txtCodigoDetalleInventario.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtCodigoDetalleInventario.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtCodigoDetalleInventario.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtCodigoDetalleInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoDetalleInventario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalleInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtCodigoDetalleInventario.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtCodigoDetalleInventario.Name = "txtCodigoDetalleInventario";
            this.txtCodigoDetalleInventario.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtCodigoDetalleInventario.Placeholder = "Automático";
            this.txtCodigoDetalleInventario.ReadOnly = true;
            this.txtCodigoDetalleInventario.TabIndex = 10;
            // 
            // lblInventario
            // 
            this.lblInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblInventario.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(200, 26);
            this.lblInventario.Text = "Inventario *";
            this.lblInventario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboInventario
            // 
            this.cboInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.cboInventario.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.cboInventario.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboInventario.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboInventario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInventario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cboInventario.FormattingEnabled = true;
            this.cboInventario.ItemHeight = 34;
            this.cboInventario.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.cboInventario.Name = "cboInventario";
            this.cboInventario.TabIndex = 11;
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblTipoMovimiento.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(200, 26);
            this.lblTipoMovimiento.Text = "Tipo de movimiento *";
            this.lblTipoMovimiento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboTipoMovimiento
            // 
            this.cboTipoMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.cboTipoMovimiento.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.cboTipoMovimiento.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboTipoMovimiento.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboTipoMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipoMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cboTipoMovimiento.FormattingEnabled = true;
            this.cboTipoMovimiento.ItemHeight = 34;
            this.cboTipoMovimiento.Items.AddRange(new object[] { "Entrada", "Salida" });
            this.cboTipoMovimiento.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.cboTipoMovimiento.Name = "cboTipoMovimiento";
            this.cboTipoMovimiento.TabIndex = 12;
            // 
            // lblFechaMovimiento
            // 
            this.lblFechaMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaMovimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblFechaMovimiento.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblFechaMovimiento.Name = "lblFechaMovimiento";
            this.lblFechaMovimiento.Size = new System.Drawing.Size(200, 26);
            this.lblFechaMovimiento.Text = "Fecha del movimiento *";
            this.lblFechaMovimiento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFechaMovimiento
            // 
            this.dtpFechaMovimiento.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.dtpFechaMovimiento.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.dtpFechaMovimiento.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.dtpFechaMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaMovimiento.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMovimiento.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.dtpFechaMovimiento.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            this.dtpFechaMovimiento.Size = new System.Drawing.Size(200, 40);
            this.dtpFechaMovimiento.TabIndex = 13;
            // 
            // lblIngreso
            // 
            this.lblIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(0, 0, 10, 4);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(200, 26);
            this.lblIngreso.Text = "Ingreso *";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIngreso
            // 
            this.txtIngreso.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtIngreso.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtIngreso.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngreso.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(0, 2, 10, 8);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtIngreso.Placeholder = "0";
            this.txtIngreso.SoloDecimales = true;
            this.txtIngreso.TabIndex = 14;
            // 
            // lblEgreso
            // 
            this.lblEgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEgreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(10, 0, 0, 4);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(200, 26);
            this.lblEgreso.Text = "Egreso *";
            this.lblEgreso.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEgreso
            // 
            this.txtEgreso.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtEgreso.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtEgreso.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtEgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEgreso.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtEgreso.Margin = new System.Windows.Forms.Padding(10, 2, 0, 8);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtEgreso.Placeholder = "0";
            this.txtEgreso.SoloDecimales = true;
            this.txtEgreso.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(200, 26);
            this.lblDescripcion.Text = "Descripción *";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtDescripcion.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtDescripcion.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtDescripcion.Placeholder = "Ej. Ingreso de martillos y destornilladores";
            this.txtDescripcion.TabIndex = 16;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.flpAcciones);
            this.pnlAcciones.ColorRelleno = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.flpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Size = new System.Drawing.Size(952, 44);
            this.flpAcciones.WrapContents = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
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
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
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
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
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
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
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
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.pnlEspacioAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.pnlEspacioAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEspacioAcciones.Name = "pnlEspacioAcciones";
            this.pnlEspacioAcciones.Size = new System.Drawing.Size(980, 14);
            // 
            // DetallesInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1036, 656);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetallesInventarioForm";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.Text = "Detalle de inventario";
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.pnlEncabezadoForm);
            this.Load += new System.EventHandler(this.DetallesInventarioForm_Load);
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
        private FerreteriaSistema.UI.Controles.EtiquetaDegradado lblTitulo;
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
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpEntradas;
        private FerreteriaSistema.UI.Controles.BotonRedondeado chpSalidas;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDetalleInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TabPage tabGestionar;
        private FerreteriaSistema.UI.Controles.PanelRedondeado pnlFormulario;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblSeccionDesc;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigoDetalleInventario;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtCodigoDetalleInventario;
        private System.Windows.Forms.Label lblInventario;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboInventario;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboTipoMovimiento;
        private System.Windows.Forms.Label lblFechaMovimiento;
        private FerreteriaSistema.UI.Controles.DateTimePickerOscuro dtpFechaMovimiento;
        private System.Windows.Forms.Label lblIngreso;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtIngreso;
        private System.Windows.Forms.Label lblEgreso;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtEgreso;
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
