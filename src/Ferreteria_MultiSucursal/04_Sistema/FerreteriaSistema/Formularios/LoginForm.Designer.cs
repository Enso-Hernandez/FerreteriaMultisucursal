namespace FerreteriaSistema.Formularios
{
    partial class LoginForm
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
            this.btnCerrar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.icoLogo = new FerreteriaSistema.UI.Controles.MosaicoIcono();
            this.lblTitulo = new FerreteriaSistema.UI.Controles.EtiquetaDegradado();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnVerContrasena = new FontAwesome.Sharp.IconButton();
            this.txtContrasena = new FerreteriaSistema.UI.Controles.TextBoxOscuro();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cboxSucursal = new FerreteriaSistema.UI.Controles.ComboBoxOscuro();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnIngresar = new FerreteriaSistema.UI.Controles.BotonRedondeado();
            this.lblPie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
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
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(392, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Radio = 8;
            this.btnCerrar.Size = new System.Drawing.Size(36, 36);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // icoLogo
            //
            this.icoLogo.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.icoLogo.Icono = FontAwesome.Sharp.IconChar.Toolbox;
            this.icoLogo.Location = new System.Drawing.Point(172, 48);
            this.icoLogo.Name = "icoLogo";
            this.icoLogo.Radio = 28;
            this.icoLogo.Size = new System.Drawing.Size(96, 96);
            this.icoLogo.TabIndex = 8;
            this.icoLogo.TamanoIcono = 46;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 158);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 40);
            this.lblTitulo.Text = "Ferretería Multisucursal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(24, 198);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(392, 24);
            this.lblSubtitulo.Text = "Inicia sesión para continuar";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblUsuario.Location = new System.Drawing.Point(48, 246);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtUsuario.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtUsuario.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(48, 270);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.txtUsuario.Placeholder = "Ingresa tu usuario";
            this.txtUsuario.Size = new System.Drawing.Size(344, 44);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblContrasena.Location = new System.Drawing.Point(48, 328);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Text = "Contraseña";
            // 
            // btnVerContrasena
            // 
            this.btnVerContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnVerContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerContrasena.FlatAppearance.BorderSize = 0;
            this.btnVerContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnVerContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnVerContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerContrasena.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.btnVerContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena.IconSize = 18;
            this.btnVerContrasena.Location = new System.Drawing.Point(354, 358);
            this.btnVerContrasena.Name = "btnVerContrasena";
            this.btnVerContrasena.Size = new System.Drawing.Size(32, 28);
            this.btnVerContrasena.TabIndex = 6;
            this.btnVerContrasena.TabStop = false;
            this.btnVerContrasena.UseVisualStyleBackColor = false;
            this.btnVerContrasena.Click += new System.EventHandler(this.btnVerContrasena_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.txtContrasena.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.txtContrasena.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtContrasena.Location = new System.Drawing.Point(48, 352);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Padding = new System.Windows.Forms.Padding(12, 8, 44, 8);
            this.txtContrasena.Placeholder = "Ingresa tu contraseña";
            this.txtContrasena.Size = new System.Drawing.Size(344, 44);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblSucursal.Location = new System.Drawing.Point(48, 410);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Text = "Sucursal";
            // 
            // cboxSucursal
            // 
            this.cboxSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.cboxSucursal.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.cboxSucursal.ColorBordeFoco = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboxSucursal.ColorSeleccion = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.cboxSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxSucursal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cboxSucursal.FormattingEnabled = true;
            this.cboxSucursal.ItemHeight = 34;
            this.cboxSucursal.Items.AddRange(new object[] { "Sucursal Central", "Sucursal Norte", "Sucursal Sur" });
            this.cboxSucursal.Location = new System.Drawing.Point(48, 434);
            this.cboxSucursal.Name = "cboxSucursal";
            this.cboxSucursal.Size = new System.Drawing.Size(344, 40);
            this.cboxSucursal.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.lblMensaje.Location = new System.Drawing.Point(48, 478);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(344, 24);
            this.lblMensaje.Text = "";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnIngresar.IconColor = System.Drawing.Color.White;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 18;
            this.btnIngresar.Location = new System.Drawing.Point(48, 506);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Radio = 10;
            this.btnIngresar.Size = new System.Drawing.Size(344, 48);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblPie
            // 
            this.lblPie.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(144)))));
            this.lblPie.Location = new System.Drawing.Point(24, 596);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(392, 22);
            this.lblPie.Text = "© 2026 Ferretería Multisucursal  ·  v1.0";
            this.lblPie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(440, 640);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión - Ferretería Multisucursal";
            this.Controls.Add(this.btnVerContrasena);
            this.Controls.Add(this.lblPie);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cboxSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.icoLogo);
            this.Controls.Add(this.btnCerrar);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FerreteriaSistema.UI.Controles.BotonRedondeado btnCerrar;
        private FerreteriaSistema.UI.Controles.MosaicoIcono icoLogo;
        private FerreteriaSistema.UI.Controles.EtiquetaDegradado lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private FontAwesome.Sharp.IconButton btnVerContrasena;
        private FerreteriaSistema.UI.Controles.TextBoxOscuro txtContrasena;
        private System.Windows.Forms.Label lblSucursal;
        private FerreteriaSistema.UI.Controles.ComboBoxOscuro cboxSucursal;
        private System.Windows.Forms.Label lblMensaje;
        private FerreteriaSistema.UI.Controles.BotonRedondeado btnIngresar;
        private System.Windows.Forms.Label lblPie;
    }
}
