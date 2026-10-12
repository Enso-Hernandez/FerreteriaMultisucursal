using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// TabControl que oculta las pestañas y los bordes clásicos en tiempo de ejecución.
    /// En el Diseñador de Visual Studio las pestañas siguen visibles para poder editarlas.
    /// La navegación se hace con botones propios (btnTabConsultar / btnTabGestionar).
    /// </summary>
    [ToolboxItem(true)]
    public class TabControlSinPestanas : TabControl
    {
        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m)
        {
            // Hace que el área de contenido ocupe todo el control (sin pestañas ni borde 3D).
            if (m.Msg == TCM_ADJUSTRECT && !DesignMode)
            {
                m.Result = (IntPtr)1;
                return;
            }
            base.WndProc(ref m);
        }

        // Evita cambiar de pestaña con Ctrl+Tab (la navegación es solo visual por botones).
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab) { e.Handled = true; return; }
            base.OnKeyDown(e);
        }
    }
}
