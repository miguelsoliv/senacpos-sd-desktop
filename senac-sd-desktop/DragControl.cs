using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    class DragControl : Component
    {
        private Control _handleControl;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                ReleaseCapture();
                SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }

        public Control SelectControl
        {
            get => _handleControl;
            set
            {
                this._handleControl = value;
                this._handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }
    }
}