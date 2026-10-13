using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Etiqueta para títulos grandes con las letras en degradado (blanco → lila → celeste).
    /// Se usa igual que un Label: lblTitulo.Text = "Sucursales";
    /// </summary>
    [ToolboxItem(true)]
    public class EtiquetaDegradado : Label
    {
        private Color colorInicio = Color.White;
        private Color colorMedio = ColorTranslator.FromHtml("#C4B5FD");
        private Color colorFin = ColorTranslator.FromHtml("#67E8F9");

        public EtiquetaDegradado()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
        }

        [Category("Diseño Dark"), Description("Color del inicio del texto (izquierda).")]
        public Color ColorInicio
        {
            get { return colorInicio; }
            set { colorInicio = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color del centro del texto.")]
        public Color ColorMedio
        {
            get { return colorMedio; }
            set { colorMedio = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color del final del texto (derecha).")]
        public Color ColorFin
        {
            get { return colorFin; }
            set { colorFin = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(Text)) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            // El texto se convierte en una figura (GraphicsPath) para poder rellenarlo con un degradado.
            using (GraphicsPath ruta = new GraphicsPath())
            using (StringFormat formato = new StringFormat(StringFormat.GenericTypographic))
            {
                float tamanoEnPixeles = Font.SizeInPoints * g.DpiY / 72f;
                ruta.AddString(Text, Font.FontFamily, (int)Font.Style, tamanoEnPixeles, PointF.Empty, formato);

                RectangleF limites = ruta.GetBounds();
                if (limites.Width < 1 || limites.Height < 1) return;

                // Posición según TextAlign (igual que un Label): izquierda / centro / derecha y arriba / medio / abajo.
                // Un Label normal deja un pequeño margen antes del texto (1/6 de la altura de la letra);
                // se respeta para que el título quede en el mismo lugar que en el Diseñador.
                Rectangle area = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Horizontal, Height - Padding.Vertical);
                float altoLinea = Font.GetHeight(g);
                float margen = Font.Height / 6f;
                float x = area.X + margen - limites.X;
                if (EsCentro(TextAlign)) x = area.X + (area.Width - limites.Width) / 2f - limites.X;
                else if (EsDerecha(TextAlign)) x = area.Right - margen - limites.Width - limites.X;
                float y = area.Y + 2;
                if (EsMedio(TextAlign)) y = area.Y + (area.Height - altoLinea) / 2f + 2;
                else if (EsAbajo(TextAlign)) y = area.Bottom - altoLinea;

                using (Matrix mover = new Matrix())
                {
                    mover.Translate(x, y);
                    ruta.Transform(mover);
                }
                limites = ruta.GetBounds();

                using (LinearGradientBrush pincel = new LinearGradientBrush(limites, colorInicio, colorFin, LinearGradientMode.Horizontal))
                {
                    ColorBlend mezcla = new ColorBlend();
                    mezcla.Colors = new[] { colorInicio, colorInicio, colorMedio, colorFin };
                    mezcla.Positions = new[] { 0f, 0.35f, 0.7f, 1f };
                    pincel.InterpolationColors = mezcla;
                    g.FillPath(pincel, ruta);
                }
            }
        }

        private static bool EsCentro(ContentAlignment a) { return a == ContentAlignment.TopCenter || a == ContentAlignment.MiddleCenter || a == ContentAlignment.BottomCenter; }
        private static bool EsDerecha(ContentAlignment a) { return a == ContentAlignment.TopRight || a == ContentAlignment.MiddleRight || a == ContentAlignment.BottomRight; }
        private static bool EsMedio(ContentAlignment a) { return a == ContentAlignment.MiddleLeft || a == ContentAlignment.MiddleCenter || a == ContentAlignment.MiddleRight; }
        private static bool EsAbajo(ContentAlignment a) { return a == ContentAlignment.BottomLeft || a == ContentAlignment.BottomCenter || a == ContentAlignment.BottomRight; }
    }
}
