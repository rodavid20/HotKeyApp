using System;
using System.Windows.Forms;

namespace HotKeyApp
{
    public partial class FrmMain : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static Keys increaseBrightnessKey = Keys.F6;
        public static Keys decreaseBrightnessKey = Keys.F5;

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public FrmMain()
        {
            InitializeComponent();

            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, increaseBrightnessKey.GetHashCode());
            id = 1;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, decreaseBrightnessKey.GetHashCode());            
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                byte brightness;
                //label1.Text += "Hotkey has been pressed!\n";
                if (key == increaseBrightnessKey)
                {
                    brightness = WindowsSettingsBrightnessController.SetBrightness(increase: true);
                    ShowForm(brightness);
                }
                else if (key == decreaseBrightnessKey)
                {
                    brightness = WindowsSettingsBrightnessController.SetBrightness(increase: false);
                    ShowForm(brightness);
                }
            }
        }

        private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 1);
        }

        private void tbarBrightness_ValueChanged(object sender, EventArgs e)
        {
            WindowsSettingsBrightnessController.SetBrightness(tbarBrightness.Value);
            lblBrightness.Text = tbarBrightness.Value.ToString();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            byte b = WindowsSettingsBrightnessController.GetBrightness();
            ShowForm(b);
        }

        private void ShowForm(byte brightness)
        {
            Show();
            tbarBrightness.Value = brightness;
            lblBrightness.Text = brightness.ToString();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
