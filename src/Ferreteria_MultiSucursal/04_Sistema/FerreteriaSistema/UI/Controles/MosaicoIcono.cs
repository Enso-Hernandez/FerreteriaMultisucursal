using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Cuadro (o círculo) con degradado de color y un ícono de FontAwesome en el centro.
    /// Se usa para el logo, el avatar del usuario y los íconos de las tarjetas.
    /// Con SoloBorde = true se dibuja un anillo de color (como el avatar de la imagen de referencia).
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("Click")]
    public class MosaicoIcono : Control
    {
        private IconChar icono = IconChar.Toolbox;
        private Color colorIcono = Color.White;
        private Color colorInicio = Tema.Celeste;
        private Color colorFin = Tema.AcentoFin;
        private int radio = 14;
        private bool circular;
        private bool soloBorde;
        private int tamanoIcono;

        public MosaicoIcono()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            Size = new Size(48, 48);
        }

        [Category("Diseño Dark"), DefaultValue(IconChar.Toolbox)]
        public IconChar Icono
        {
            get { return icono; }
            set { icono = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color del ícono.")]
        public Color ColorIcono
        {
            get { return colorIcono; }
            set { colorIcono = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color de arriba a la izquierda del degradado.")]
        public Color ColorInicio
        {
            get { return colorInicio; }
            set { colorInicio = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color de abajo a la derecha del degradado.")]
        public Color ColorFin
        {
            get { return colorFin; }
            set { colorFin = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(14)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Dibuja un círculo en lugar de un cuadro."), DefaultValue(false)]
        public bool Circular
        {
            get { return circular; }
            set { circular = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Solo dibuja un anillo de color (el centro queda oscuro)."), DefaultValue(false)]
        public bool SoloBorde
        {
            get { return soloBorde; }
            set { soloBorde = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Tamaño del ícono en píxeles. 0 = la mitad del control."), DefaultValue(0)]
        public int TamanoIcono
        {
            get { return tamanoIcono; }
            set { tamanoIcono = value < 0 ? 0 : value; Invalidate(); }
        }

        public bool ShouldSerializeColorIcono() { return colorIcono != Color.White; }
        public void ResetColorIcono() { ColorIcono = Color.White; }
        public bool ShouldSerializeColorInicio() { return colorInicio != Tema.Celeste; }
        public void ResetColorInicio() { ColorInicio = Tema.Celeste; }
        public bool ShouldSerializeColorFin() { return colorFin != Tema.AcentoFin; }
        public void ResetColorFin() { ColorFin = Tema.AcentoFin; }

        // El fondo completo se dibuja en OnPaint.
        protected override void OnPaintBackground(PaintEventArgs e) { }

        private GraphicsPath CrearRuta(RectangleF rect)
        {
            if (!circular) return Tema.CrearRutaRedondeada(rect, radio);
            GraphicsPath ruta = new GraphicsPath();
            ruta.AddEllipse(rect);
            return ruta;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Tema.PintarFondo(this, g);

            RectangleF rect = new RectangleF(0.5f, 0.5f, Width - 2f, Height - 2f);
            using (GraphicsPath ruta = CrearRuta(rect))
            {
                Tema.RellenarRuta(g, ruta, colorInicio, colorFin);
            }

            if (soloBorde)
            {
                // Centro oscuro dentro del anillo de color.
                RectangleF interior = RectangleF.Inflate(rect, -2.5f, -2.5f);
                using (GraphicsPath ruta = CrearRuta(interior))
                using (SolidBrush pincel = new SolidBrush(Tema.FondoPrincipal))
                {
                    g.FillPath(pincel, ruta);
                }
            }

            int tamano = tamanoIcono > 0 ? tamanoIcono : Math.Max(8, Math.Min(Width, Height) / 2);
            Bitmap imagen = Tema.Icono(icono, colorIcono, tamano);
            g.DrawImage(imagen, (Width - imagen.Width) / 2, (Height - imagen.Height) / 2);
        }
    }
}
