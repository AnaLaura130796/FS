using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace inventariosFS
{
    class ClassAnimador
    {

        public enum Effect { Roll, Slide, Center, Blend };

        public static void activarAnimacion(Control ctl)
        {
            ClassAnimador.animar(ctl, ClassAnimador.Effect.Slide, 100, 360);
            ctl.Visible = false;
        }
        public static void animar(Control ctl, Effect efecto, int msec, int angulo)
        {
            int banderas = effmap[(int)efecto];

            if (ctl.Visible)
            {
                banderas |= 0x10000;
                angulo += 180;
            }
            else
            {
                if (ctl.TopLevelControl == ctl)
                    banderas |= 0x20000;
                else if (efecto == Effect.Blend) throw new ArgumentException();
            }
            banderas |= dirmap[(angulo % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, banderas);
            if (!ok) throw new Exception("Falló la animación");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };
        [DllImport("user32.dll")]

        private static extern bool AnimateWindow(IntPtr handle, int msec, int banderas);
    }
}
