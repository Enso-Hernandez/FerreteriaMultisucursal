using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Tarjeta con esquinas redondeadas (GraphicsPath + antialias).
    /// ColorRelleno puede ser semitransparente (vidrio): se ve el fondo degradado a través de la tarjeta.
    /// Con ColorDegradado la tarjeta se rellena con un degradado diagonal (tinte de color).
    /// BackColor queda transparente para que las etiquetas de adentro no pinten un rectángulo.
    /// </summary>
    [ToolboxItem(true)]
    public class PanelRedondeado : Panel
    {
        private int radio = 18;
        private Color colorRelleno = Tema.Vidrio;
        private Color colorDegradado = Color.Empty;
        private Color colorBorde = Tema.BordeVidrio;
        private int grosorBorde = 1;
        private int sangria;

        public PanelRedondeado()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            ForeColor = Tema.Texto;
            Padding = new Padding(16);
        }

        [Category("Diseño Dark"), Description("Radio de las esquinas en píxeles."), DefaultValue(18)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color de la tarjeta. Con poca opacidad se ve como vidrio.")]
        public Color ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; Invalidate(true); }
        }

        [Category("Diseño Dark"), Description("Segundo color del relleno (degradado diagonal). Empty = un solo color.")]
        public Color ColorDegradado
        {
            get { return colorDegradado; }
            set { colorDegradado = value; Invalidate(true); }
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

        [Category("Diseño Dark"), Description("Espacio libre entre el borde del control y la tarjeta (efecto flotante)."), DefaultValue(0)]
        public int Sangria
        {
            get { return sangria; }
            set { sangria = value < 0 ? 0 : value; Invalidate(); }
        }

        public bool ShouldSerializeColorRelleno() { return colorRelleno != Tema.Vidrio; }
        public void ResetColorRelleno() { ColorRelleno = Tema.Vidrio; }
        public bool ShouldSerializeColorDegradado() { return colorDegradado != Color.Empty; }
        public void ResetColorDegradado() { ColorDegradado = Color.Empty; }
        public bool ShouldSerializeColorBorde() { return colorBorde != Tema.BordeVidrio; }
        public void ResetColorBorde() { ColorBorde = Tema.BordeVidrio; }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);

            // 1) Lo que hay detrás de la tarjeta (degradado de la ventana y otras tarjetas).
            Tema.PintarFondo(this, g);

            // 2) La tarjeta.
            PintarVidrio(g);
        }

        /// <summary>
        /// Dibuja solo la tarjeta (relleno y borde). Tema.PintarFondo lo usa para que los controles
        /// de adentro dibujen el mismo vidrio detrás de sus esquinas redondeadas.
        /// </summary>
        public void PintarVidrio(Graphics g)
        {
            RectangleF rect = new RectangleF(sangria, sangria, Width - 1f - sangria * 2, Height - 1f - sangria * 2);
            if (rect.Width < 1 || rect.Height < 1) return;

            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
            {
                Tema.RellenarRuta(g, ruta, colorRelleno, colorDegradado);

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
