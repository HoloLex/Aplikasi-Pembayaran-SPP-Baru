using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    public static class Tools
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd,  int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ReleaseCapture();
        const int WM_MCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public static void Move_Form(this Control control, IntPtr Handle)
        {
            control.MouseMove += new MouseEventHandler(Move);
            void Move(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_MCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
    }
}
