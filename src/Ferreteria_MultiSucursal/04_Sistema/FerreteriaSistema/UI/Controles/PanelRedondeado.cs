using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Panel contenedor con esquinas redondeadas (GraphicsPath + antialias).
    /// BackColor = color de relleno de la "tarjeta".
    /// </summary>
    [ToolboxItem(true)]
    public class PanelRedondeado : Panel
    {
        private int radio = 12;
        private Color colorBorde = Color.Empty;
        private int grosorBorde = 1;

        public PanelRedondeado()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            BackColor = ColorTranslator.FromHtml("#252526");
            ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            Padding = new Padding(16);
        }

        [Category("Diseño Dark"), Description("Radio de las esquinas en píxeles."), DefaultValue(12)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color del borde. Empty = sin borde.")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set { colorBorde = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Grosor del borde en píxeles."), DefaultValue(1)]
        public int GrosorBorde
        {
            get { return grosorBorde; }
            set { grosorBorde = value < 0 ? 0 : value; Invalidate(); }
        }

        public bool ShouldSerializeColorBorde() { return colorBorde != Color.Empty; }
        public void ResetColorBorde() { ColorBorde = Color.Empty; }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);

            // 1) Pintar las esquinas con el color del contenedor padre.
            g.Clear(Tema.ObtenerColorFondo(Parent));

            // 2) Rellenar la "tarjeta" redondeada.
            RectangleF rect = new RectangleF(0, 0, Width - 1f, Height - 1f);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
            using (SolidBrush relleno = new SolidBrush(BackColor))
            {
                g.FillPath(relleno, ruta);

                if (colorBorde != Color.Empty && grosorBorde > 0)
                {
                    using (Pen pluma = new Pen(colorBorde, grosorBorde))
                    {
                        pluma.Alignment = PenAlignment.Inset;
                        g.DrawPath(pluma, ruta);
                    }
                }
            }
        }

        protected override void OnParentBackColorChanged(System.EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }
}
