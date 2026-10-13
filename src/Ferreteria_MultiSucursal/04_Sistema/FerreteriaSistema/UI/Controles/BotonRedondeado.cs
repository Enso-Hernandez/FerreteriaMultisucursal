using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Botón plano con esquinas redondeadas e ícono de FontAwesome.
    /// Dibuja su propio fondo con GraphicsPath (hover / presionado / deshabilitado).
    /// - BackColor transparente: solo se ilumina al pasar el mouse (botones de menú o de cerrar).
    /// - BackColor semitransparente: botón de vidrio.
    /// - Colores de la paleta (Acento, Éxito, Peligro, Advertencia): se dibujan con degradado.
    /// </summary>
    [ToolboxItem(true)]
    public class BotonRedondeado : IconButton
    {
        private int radio = 10;
        private Color colorHover = Color.Empty;
        private Color colorDegradado = Color.Empty;
        private bool mouseEncima;
        private bool presionado;

        public BotonRedondeado()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Tema.Acento;
            ForeColor = Color.White;
            IconColor = Color.White;
            IconSize = 20;
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            Size = new Size(140, 40);
        }

        [Category("Diseño Dark"), Description("Radio de las esquinas en píxeles."), DefaultValue(10)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color al pasar el mouse. Empty = se calcula automáticamente.")]
        public Color ColorHover
        {
            get { return colorHover; }
            set { colorHover = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Segundo color del degradado. Empty = el de la paleta (o un solo color).")]
        public Color ColorDegradado
        {
            get { return colorDegradado; }
            set { colorDegradado = value; Invalidate(); }
        }

        public bool ShouldSerializeColorHover() { return colorHover != Color.Empty; }
        public void ResetColorHover() { ColorHover = Color.Empty; }
        public bool ShouldSerializeColorDegradado() { return colorDegradado != Color.Empty; }
        public void ResetColorDegradado() { ColorDegradado = Color.Empty; }

        // Oculta el rectángulo de foco punteado clásico de Windows.
        protected override bool ShowFocusCues { get { return false; } }

        protected override void OnMouseEnter(EventArgs e) { mouseEncima = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { mouseEncima = false; presionado = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { if (e.Button == MouseButtons.Left) { presionado = true; Invalidate(); } base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { presionado = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        // El fondo completo se dibuja en OnPaint.
        protected override void OnPaintBackground(PaintEventArgs pevent) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Tema.PintarFondo(this, g);

            // Color de relleno según el estado visual del botón.
            Color inicio = BackColor;
            Color fin = colorDegradado != Color.Empty ? colorDegradado : Tema.ColorFinDegradado(BackColor);

            if (!Enabled)
            {
                inicio = Tema.ConOpacidad(inicio, inicio.A * 35 / 100);
                if (fin != Color.Empty) fin = Tema.ConOpacidad(fin, fin.A * 35 / 100);
            }
            else if (presionado)
            {
                inicio = inicio.A == 0 ? Tema.VidrioClaro : Tema.Oscurecer(inicio, 0.15f);
                if (fin != Color.Empty) fin = Tema.Oscurecer(fin, 0.15f);
            }
            else if (mouseEncima)
            {
                if (colorHover != Color.Empty) { inicio = colorHover; fin = Tema.ColorFinDegradado(colorHover); }
                else
                {
                    inicio = inicio.A == 0 ? Tema.Vidrio : Tema.Aclarar(inicio, 0.12f);
                    if (fin != Color.Empty) fin = Tema.Aclarar(fin, 0.12f);
                }
            }

            if (inicio.A > 0)
            {
                RectangleF rect = new RectangleF(0, 0, Width - 1f, Height - 1f);
                using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
                {
                    Tema.RellenarRuta(g, ruta, inicio, fin);
                }
            }

            DibujarContenido(g);
        }

        /// <summary>Dibuja ícono + texto centrados como un solo grupo.</summary>
        private void DibujarContenido(Graphics g)
        {
            // Sin ícono (IconChar.None) FontAwesome igual crea una imagen vacía: se ignora para centrar el texto.
            Image icono = IconChar == IconChar.None ? null : Image;
            bool hayTexto = !string.IsNullOrEmpty(Text);
            Color colorTexto = Enabled ? ForeColor : Tema.Mezclar(ForeColor, Tema.ObtenerColorFondo(this), 0.55f);

            Size tamTexto = hayTexto
                ? TextRenderer.MeasureText(g, Text, Font, Size.Empty, TextFormatFlags.NoPadding)
                : Size.Empty;

            int separacion = icono != null && hayTexto ? 8 : 0;
            int anchoIcono = icono != null ? icono.Width : 0;
            int anchoTotal = anchoIcono + separacion + tamTexto.Width;

            int x;
            if (TextAlign == ContentAlignment.MiddleLeft || TextAlign == ContentAlignment.TopLeft || TextAlign == ContentAlignment.BottomLeft)
                x = Padding.Left + 12;
            else
                x = (Width - anchoTotal) / 2;

            if (icono != null)
            {
                int y = (Height - icono.Height) / 2;
                if (Enabled)
                {
                    g.DrawImage(icono, x, y, icono.Width, icono.Height);
                }
                else
                {
                    using (ImageAttributes atributos = new ImageAttributes())
                    {
                        ColorMatrix matriz = new ColorMatrix { Matrix33 = 0.40f };
                        atributos.SetColorMatrix(matriz);
                        g.DrawImage(icono, new Rectangle(x, y, icono.Width, icono.Height),
                            0, 0, icono.Width, icono.Height, GraphicsUnit.Pixel, atributos);
                    }
                }
                x += anchoIcono + separacion;
            }

            if (hayTexto)
            {
                Rectangle rectTexto = new Rectangle(x, 0, tamTexto.Width + 2, Height);
                TextRenderer.DrawText(g, Text, Font, rectTexto, colorTexto,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.SingleLine);
            }
        }
    }
}
