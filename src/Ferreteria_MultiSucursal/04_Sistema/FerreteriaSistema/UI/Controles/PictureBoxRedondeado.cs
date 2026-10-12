using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// PictureBox con esquinas redondeadas o forma circular (ideal para el logo).
    /// La imagen se recorta con un GraphicsPath y se dibuja con antialias.
    /// </summary>
    [ToolboxItem(true)]
    public class PictureBoxRedondeado : PictureBox
    {
        private int radio = 16;
        private bool circular;
        private Color colorBorde = Color.Empty;
        private int grosorBorde = 2;
        private int margenImagen = 12;

        public PictureBoxRedondeado()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            BackColor = ColorTranslator.FromHtml("#3498DB");
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new Size(80, 80);
        }

        [Category("Diseño Dark"), DefaultValue(16)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Dibuja el control como un círculo."), DefaultValue(false)]
        public bool Circular
        {
            get { return circular; }
            set { circular = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set { colorBorde = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(2)]
        public int GrosorBorde
        {
            get { return grosorBorde; }
            set { grosorBorde = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Espacio interno alrededor de la imagen."), DefaultValue(12)]
        public int MargenImagen
        {
            get { return margenImagen; }
            set { margenImagen = value < 0 ? 0 : value; Invalidate(); }
        }

        public bool ShouldSerializeColorBorde() { return colorBorde != Color.Empty; }
        public void ResetColorBorde() { ColorBorde = Color.Empty; }

        private GraphicsPath CrearRuta()
        {
            RectangleF rect = new RectangleF(1, 1, Width - 3f, Height - 3f);
            if (!circular) return Tema.CrearRutaRedondeada(rect, radio);
            GraphicsPath ruta = new GraphicsPath();
            ruta.AddEllipse(rect);
            return ruta;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            g.Clear(Tema.ObtenerColorFondo(Parent));

            using (GraphicsPath ruta = CrearRuta())
            {
                using (SolidBrush pincel = new SolidBrush(BackColor))
                {
                    g.FillPath(pincel, ruta);
                }

                if (Image != null)
                {
                    g.SetClip(ruta);
                    Rectangle area = new Rectangle(margenImagen, margenImagen,
                        Math.Max(1, Width - margenImagen * 2), Math.Max(1, Height - margenImagen * 2));
                    g.DrawImage(Image, CalcularRectanguloZoom(Image.Size, area));
                    g.ResetClip();
                }

                if (colorBorde != Color.Empty && grosorBorde > 0)
                {
                    using (Pen pluma = new Pen(colorBorde, grosorBorde))
                    {
                        g.DrawPath(pluma, ruta);
                    }
                }
            }
        }

        private Rectangle CalcularRectanguloZoom(Size imagen, Rectangle area)
        {
            if (SizeMode == PictureBoxSizeMode.StretchImage) return area;
            float escala = Math.Min((float)area.Width / imagen.Width, (float)area.Height / imagen.Height);
            int ancho = (int)(imagen.Width * escala);
            int alto = (int)(imagen.Height * escala);
            return new Rectangle(area.X + (area.Width - ancho) / 2, area.Y + (area.Height - alto) / 2, ancho, alto);
        }
    }
}
