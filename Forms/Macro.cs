using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WndProcWrapper;
using System.Diagnostics;

namespace MyMacro.Forms
{
    public partial class Macro : Form
    {
        #region variables

        enum KeyState { Down, Up };
        IKeyboardMouseEvents hook;
        IntPtr _Handle = IntPtr.Zero;
        bool Flag = false;

        #endregion variables

        public Macro()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 1, 1, 1);
            this.TransparencyKey = Color.FromArgb(255, 1, 1, 1);
            this.AllowTransparency = true;
        }

        private void Macro_Shown(object sender, EventArgs e)
        {
            hook = Hook.GlobalEvents();
            hook.MouseClick += hook_MouseClick;
            hook.MouseWheel += hook_MouseWheel;
            hook.KeyDown += hook_KeyDown;
        }

        private void hook_MouseClick(object sender, MouseEventArgs e)
        {
            if (Flag && _Handle != IntPtr.Zero && _Handle == NativeMethod.GetForegroundWindow() && e.Button == MouseButtons.Middle)
            {
                NativeMethod.SendMessage(_Handle, 0x100, (uint)Keys.D1, lParam_Builder(Keys.D1, KeyState.Down));
                NativeMethod.SendMessage(_Handle, 0x101, (uint)Keys.D1, lParam_Builder(Keys.D1,KeyState.Up));
            }
        }

        private void hook_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Flag && _Handle != IntPtr.Zero && _Handle == NativeMethod.GetForegroundWindow())
            {
                if (e.Delta < -1)
                {
                    NativeMethod.SendMessage(_Handle, 0x100, (uint)Keys.Oemtilde, lParam_Builder(Keys.Oemtilde, KeyState.Down));
                    NativeMethod.SendMessage(_Handle, 0x101, (uint)Keys.Oemtilde, lParam_Builder(Keys.Oemtilde, KeyState.Up));
                }
                else if (e.Delta > 1)
                {
                    NativeMethod.SendMessage(_Handle, 0x100, (uint)Keys.X, lParam_Builder(Keys.X, KeyState.Down));
                    NativeMethod.SendMessage(_Handle, 0x101, (uint)Keys.X, lParam_Builder(Keys.X, KeyState.Up));
                }
            }
        }

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (_Handle == IntPtr.Zero || _Handle != NativeMethod.GetForegroundWindow())
                {
                    _Handle = NativeMethod.GetForegroundWindow();
                    Rectangle wRect = new Rectangle();
                    NativeMethod.GetWindowRect(_Handle, out wRect);
                    this.Location = new Point(wRect.X + 30, wRect.Y);
                    uint Pid = 0;
                    NativeMethod.GetWindowThreadProcessId(_Handle, out Pid);
                    lbl_Pid.Text = Pid.ToString() + " - " + Process.GetProcessById((int)Pid).ProcessName;
                }
                else if (_Handle == NativeMethod.GetForegroundWindow())
                {
                    _Handle = IntPtr.Zero;
                    lbl_Pid.Text = "F11 - Pilih Target / F12 - On Off";
                }
            }
            else if (e.KeyCode == Keys.F12)
            {
                if (_Handle != IntPtr.Zero && _Handle == NativeMethod.GetForegroundWindow())
                {
                    if (lbl_OnOff.Tag.ToString() == "Start")
                    {
                        lbl_OnOff.Tag = "Stop";
                        lbl_OnOff.Image = Properties.Resources.start;
                        Flag = true;
                    }
                    else if (lbl_OnOff.Tag.ToString() == "Stop")
                    {
                        lbl_OnOff.Tag = "Start";
                        lbl_OnOff.Image = Properties.Resources.stop;
                        Flag = false;
                    }
                }
            }
        }

        private uint lParam_Builder(Keys k, KeyState s)
        {
            uint ScanCode = NativeMethod.MapVirtualKeyEx((uint)k, MapVirtualKeyMapTypes.MAPVK_VK_TO_VSC, NativeMethod.LoadKeyboardLayout("", 1));
            string State = "00";
            if (s == KeyState.Down)
                State = "00";
            else if (s == KeyState.Up)
                State = "C0";
            string lParam = string.Concat(State, ScanCode.ToString("X2"), "0001");
            return Convert.ToUInt32(lParam, 16);
        }

        private void panel_Macro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(this.Handle, (uint)NativeConst.WM_NCLBUTTONDOWN, (uint)NativeConst.HT_CAPTION, 0);
            }
        }
                
        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_About_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Owner = this;
            a.ShowDialog();
        }
    }
}
