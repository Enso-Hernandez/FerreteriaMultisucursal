using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// ComboBox desplegable Dark (DropDownList): lista oscura dibujada a mano,
    /// borde redondeado y flecha minimalista.
    /// </summary>
    [ToolboxItem(true)]
    public class ComboBoxOscuro : ComboBox
    {
        private const int WM_PAINT = 0x000F;
        private Color colorBorde = Tema.Borde;
        private Color colorBordeFoco = Tema.Acento;
        private Color colorSeleccion = Tema.Acento;
        private int radio = 10;

        public ComboBoxOscuro()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            BackColor = Tema.FondoSecundario;
            ForeColor = Tema.Texto;
            Font = new Font("Segoe UI", 10.5F);
            ItemHeight = 34;
            Size = new Size(260, 40);
            Cursor = Cursors.Hand;
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

        [Category("Diseño Dark"), Description("Color del elemento resaltado en la lista.")]
        public Color ColorSeleccion
        {
            get { return colorSeleccion; }
            set { colorSeleccion = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(10)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }
        protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); Invalidate(); }
        protected override void OnSelectedIndexChanged(EventArgs e) { base.OnSelectedIndexChanged(e); Invalidate(); }

        /// <summary>Dibuja cada elemento de la lista desplegable.</summary>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // El "edit" (parte cerrada) lo dibuja WndProc; aquí solo la lista desplegada.
            if ((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit) return;

            bool resaltado = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color fondo = resaltado ? colorSeleccion : BackColor;
            using (SolidBrush pincel = new SolidBrush(fondo))
            {
                e.Graphics.FillRectangle(pincel, e.Bounds);
            }

            Rectangle rectTexto = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), Font, rectTexto,
                resaltado ? Color.White : ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT) DibujarCaja();
        }

        /// <summary>Repinta la parte visible (cerrada) del ComboBox completamente en oscuro.</summary>
        private void DibujarCaja()
        {
            using (Graphics g = Graphics.FromHwnd(Handle))
            {
                Tema.ConfigurarCalidad(g);
                Color fondoPadre = Tema.ObtenerColorFondo(Parent);
                Color relleno = Enabled ? BackColor : Tema.Mezclar(BackColor, fondoPadre, 0.5f);
                Color borde = !Enabled ? Tema.Mezclar(colorBorde, relleno, 0.5f) : (Focused || DroppedDown ? colorBordeFoco : colorBorde);

                // Las esquinas muestran lo que hay detrás (degradado o vidrio de la tarjeta).
                Tema.PintarFondo(this, g);

                RectangleF rect = new RectangleF(0.5f, 0.5f, Width - 2f, Height - 2f);
                using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
                using (SolidBrush pincel = new SolidBrush(relleno))
                using (Pen pluma = new Pen(borde, 1f))
                {
                    g.FillPath(pincel, ruta);
                    g.DrawPath(pluma, ruta);
                }

                // Texto del elemento seleccionado
                int anchoFlecha = 32;
                Rectangle rectTexto = new Rectangle(12, 0, Width - anchoFlecha - 12, Height);
                Color colorTexto = Enabled ? ForeColor : Tema.TextoSecundario;
                TextRenderer.DrawText(g, Text, Font, rectTexto, colorTexto,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine);

                // Flecha tipo "chevron"
                int cx = Width - anchoFlecha / 2 - 2;
                int cy = Height / 2;
                Color colorFlecha = Enabled ? (Focused ? colorBordeFoco : Tema.TextoSecundario) : Tema.TextoDeshabilitado;
                using (Pen pluma = new Pen(colorFlecha, 2f))
                {
                    pluma.StartCap = LineCap.Round;
                    pluma.EndCap = LineCap.Round;
                    g.DrawLines(pluma, new[]
                    {
                        new PointF(cx - 5, cy - 2.5f),
                        new PointF(cx, cy + 2.5f),
                        new PointF(cx + 5, cy - 2.5f)
                    });
                }
            }
        }
    }
}
