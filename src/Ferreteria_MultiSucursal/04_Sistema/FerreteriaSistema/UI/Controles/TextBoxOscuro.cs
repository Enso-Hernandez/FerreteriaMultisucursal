using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Cuadro de texto Dark: fondo #2D2D30, sin borde 3D, esquinas redondeadas,
    /// línea de acento al recibir el foco, texto de ayuda (placeholder) y modo contraseña.
    /// Opcional: ícono a la izquierda (Icono) y resplandor azul al enfocar (Resplandor).
    /// Se usa igual que un TextBox: txtNombre.Text, txtNombre.Enabled, etc.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("TextChanged")]
    [DefaultProperty("Text")]
    public class TextBoxOscuro : UserControl
    {
        private readonly TextBox txtInterno;
        private int radio = 8;
        private Color colorFondo = ColorTranslator.FromHtml("#2D2D30");
        private Color colorBorde = ColorTranslator.FromHtml("#3F3F46");
        private Color colorBordeFoco = ColorTranslator.FromHtml("#3498DB");
        private string placeholder = string.Empty;
        private bool soloDecimales;
        private bool enfocado;
        private IconChar icono = IconChar.None;
        private bool resplandor;

        private const int AnchoIcono = 30;     // espacio reservado para el ícono
        private const int MargenResplandor = 3; // espacio alrededor del borde para el brillo

        public TextBoxOscuro()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);

            txtInterno = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = colorFondo,
                ForeColor = ColorTranslator.FromHtml("#E0E0E0"),
                Font = new Font("Segoe UI", 10.5F)
            };

            txtInterno.TextChanged += (s, e) => OnTextChanged(e);
            txtInterno.KeyDown += (s, e) => OnKeyDown(e);
            txtInterno.KeyPress += TxtInterno_KeyPress;
            txtInterno.Enter += (s, e) => { enfocado = true; Invalidate(); };
            txtInterno.Leave += (s, e) => { enfocado = false; Invalidate(); };
            txtInterno.HandleCreated += (s, e) => AplicarPlaceholder();

            Controls.Add(txtInterno);

            ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            Font = new Font("Segoe UI", 10.5F);
            Padding = new Padding(12, 8, 12, 8);
            Size = new Size(260, 40);
            Cursor = Cursors.IBeam;
        }

        #region Propiedades

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Apariencia"), Description("Texto del control.")]
        public override string Text
        {
            get { return txtInterno != null ? txtInterno.Text : string.Empty; }
            set { if (txtInterno != null) txtInterno.Text = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Texto de ayuda cuando el campo está vacío."), DefaultValue("")]
        public string Placeholder
        {
            get { return placeholder; }
            set { placeholder = value ?? string.Empty; AplicarPlaceholder(); Invalidate(); }
        }

        [Category("Comportamiento"), Description("Oculta los caracteres (contraseñas)."), DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get { return txtInterno.UseSystemPasswordChar; }
            set { txtInterno.UseSystemPasswordChar = value; Invalidate(); }
        }

        [Category("Comportamiento"), DefaultValue(false)]
        public bool Multiline
        {
            get { return txtInterno.Multiline; }
            set
            {
                txtInterno.Multiline = value;
                txtInterno.ScrollBars = value ? ScrollBars.Vertical : ScrollBars.None;
                AjustarTextoInterno();
                if (value) Tema.AplicarScrollOscuro(txtInterno);
            }
        }

        [Category("Comportamiento"), DefaultValue(false)]
        public bool ReadOnly
        {
            get { return txtInterno.ReadOnly; }
            set { txtInterno.ReadOnly = value; }
        }

        [Category("Comportamiento"), DefaultValue(32767)]
        public int MaxLength
        {
            get { return txtInterno.MaxLength; }
            set { txtInterno.MaxLength = value; }
        }

        [Category("Comportamiento"), Description("Solo permite números y un separador decimal (precios, cantidades)."), DefaultValue(false)]
        public bool SoloDecimales
        {
            get { return soloDecimales; }
            set { soloDecimales = value; txtInterno.TextAlign = value ? HorizontalAlignment.Right : HorizontalAlignment.Left; }
        }

        [Category("Diseño Dark"), DefaultValue(8)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Ícono que se dibuja a la izquierda del texto (por ejemplo una lupa)."), DefaultValue(IconChar.None)]
        public IconChar Icono
        {
            get { return icono; }
            set { icono = value; AjustarTextoInterno(); Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Dibuja un brillo azul alrededor del borde cuando el campo tiene el foco."), DefaultValue(false)]
        public bool Resplandor
        {
            get { return resplandor; }
            set { resplandor = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color de relleno del cuadro de texto.")]
        public Color ColorFondo
        {
            get { return colorFondo; }
            set { colorFondo = value; txtInterno.BackColor = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set { colorBorde = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorBordeFoco
        {
            get { return colorBordeFoco; }
            set { colorBordeFoco = value; Invalidate(); }
        }

        /// <summary>Valor numérico del campo (0 si está vacío o no es válido).</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal ValorDecimal
        {
            get
            {
                decimal valor;
                return decimal.TryParse(txtInterno.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out valor) ? valor : 0m;
            }
            set { txtInterno.Text = value.ToString("0.00", CultureInfo.CurrentCulture); }
        }

        [Browsable(false)]
        public TextBox CajaInterna { get { return txtInterno; } }

        #endregion

        #region Comportamiento

        public new bool Focus() { return txtInterno.Focus(); }
        public void SelectAll() { txtInterno.SelectAll(); }
        public void Clear() { txtInterno.Clear(); }

        protected override void OnClick(EventArgs e) { txtInterno.Focus(); base.OnClick(e); }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); if (txtInterno != null && txtInterno.Visible) txtInterno.Focus(); }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            if (txtInterno == null) return;
            txtInterno.Font = Font;
            AjustarTextoInterno();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (txtInterno != null) txtInterno.ForeColor = ForeColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AjustarTextoInterno();
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            AjustarTextoInterno();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (txtInterno == null) return;
            // Un TextBox deshabilitado se pinta gris claro (Windows); por eso lo ocultamos
            // y dibujamos el texto nosotros mismos con colores oscuros.
            txtInterno.Visible = Enabled;
            Cursor = Enabled ? Cursors.IBeam : Cursors.Default;
            Invalidate();
        }

        private void TxtInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soloDecimales && !char.IsControl(e.KeyChar))
            {
                string separador = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                bool esSeparador = e.KeyChar.ToString() == separador || e.KeyChar == '.';
                if (esSeparador)
                {
                    if (txtInterno.Text.Contains(separador)) e.Handled = true;
                    else if (e.KeyChar.ToString() != separador)
                    {
                        // Normaliza el punto al separador decimal de la configuración regional.
                        e.Handled = true;
                        txtInterno.SelectedText = separador;
                    }
                }
                else if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            OnKeyPress(e);
        }

        private void AjustarTextoInterno()
        {
            if (txtInterno == null) return;
            int izquierda = Padding.Left + (icono != IconChar.None ? AnchoIcono : 0);
            int ancho = Math.Max(10, Width - izquierda - Padding.Right);
            if (txtInterno.Multiline)
            {
                txtInterno.Location = new Point(izquierda, Padding.Top);
                txtInterno.Size = new Size(ancho, Math.Max(10, Height - Padding.Vertical));
            }
            else
            {
                txtInterno.Width = ancho;
                txtInterno.Location = new Point(izquierda, Math.Max(0, (Height - txtInterno.Height) / 2));
            }
        }

        private void AplicarPlaceholder()
        {
            if (txtInterno == null || !txtInterno.IsHandleCreated) return;
            try
            {
                NativeMethods.SendMessage(txtInterno.Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, placeholder);
            }
            catch (EntryPointNotFoundException) { }
        }

        #endregion

        #region Dibujo (GraphicsPath)

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            g.Clear(Tema.ObtenerColorFondo(Parent));
            if (txtInterno == null) return;

            Color relleno = Enabled ? colorFondo : Tema.Mezclar(colorFondo, Tema.ObtenerColorFondo(Parent), 0.5f);
            Color borde = !Enabled ? Tema.Mezclar(colorBorde, relleno, 0.5f) : (enfocado ? colorBordeFoco : colorBorde);

            // Con Resplandor se deja un pequeño margen alrededor para dibujar el brillo.
            float margen = resplandor ? MargenResplandor : 0f;
            RectangleF rect = new RectangleF(0.5f + margen, 0.5f + margen, Width - 2f - margen * 2, Height - 2f - margen * 2);

            if (resplandor && enfocado && Enabled)
            {
                // Brillo: tres contornos del color de foco cada vez más transparentes.
                int[] transparencias = { 70, 40, 18 };
                for (int i = 0; i < transparencias.Length; i++)
                {
                    RectangleF anillo = RectangleF.Inflate(rect, i + 1, i + 1);
                    using (GraphicsPath rutaAnillo = Tema.CrearRutaRedondeada(anillo, radio + i + 1))
                    using (Pen plumaAnillo = new Pen(Color.FromArgb(transparencias[i], colorBordeFoco), 1.2f))
                    {
                        g.DrawPath(plumaAnillo, rutaAnillo);
                    }
                }
            }

            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
            using (SolidBrush pincel = new SolidBrush(relleno))
            using (Pen pluma = new Pen(borde, enfocado ? 1.6f : 1f))
            {
                g.FillPath(pincel, ruta);
                g.DrawPath(pluma, ruta);
            }

            if (icono != IconChar.None)
            {
                Color colorIcono = enfocado && Enabled ? colorBordeFoco : Tema.TextoSecundario;
                Bitmap imagen = Tema.Icono(icono, colorIcono, 21);
                g.DrawImage(imagen, Padding.Left, (Height - imagen.Height) / 2);
            }

            if (!Enabled)
            {
                // Texto dibujado manualmente cuando el campo está bloqueado.
                string texto = txtInterno.Text;
                if (txtInterno.UseSystemPasswordChar && texto.Length > 0) texto = new string('●', texto.Length);
                bool vacio = string.IsNullOrEmpty(texto);
                if (vacio) texto = placeholder;

                int izquierda = Padding.Left + (icono != IconChar.None ? AnchoIcono : 0);
                Rectangle rectTexto = new Rectangle(izquierda, Padding.Top, Width - izquierda - Padding.Right, Height - Padding.Vertical);
                TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis |
                    (txtInterno.Multiline ? TextFormatFlags.WordBreak | TextFormatFlags.Top : TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine) |
                    (soloDecimales ? TextFormatFlags.Right : TextFormatFlags.Left);
                Color colorTexto = vacio ? ColorTranslator.FromHtml("#5A5A5A") : ColorTranslator.FromHtml("#8A8A8A");
                TextRenderer.DrawText(g, texto, Font, rectTexto, colorTexto, flags);
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        #endregion
    }
}
