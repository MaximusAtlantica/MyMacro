using System;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WndProcWrapper
{
    public class NativeMethod
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out  Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("User32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool redraw);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern int PostMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern bool PostThreadMessage(int idThread, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetProcessIdOfThread(IntPtr handle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKeyEx(uint uCode, MapVirtualKeyMapTypes uMapType, IntPtr dwhkl);
    }

    public enum NativeConst
    {
        HT_CAPTION = 0x2,
        //nCmdShow
        SW_FORCEMINIMIZE = 0x0011,
        SW_HIDE = 0x0000,
        SW_MAXIMIZE = 0x0003,
        SW_MINIMIZE = 0x0006,
        SW_RESTORE = 0x0009,
        SW_SHOW = 0x0005,
        SW_SHOWDEFAULT = 0x0010,
        SW_SHOWMAXIMIZED = 0x0003,
        SW_SHOWMINIMIZED = 0x0002,
        SW_SHOWMINNOACTIVE = 0x0007,
        SW_SHOWNA = 0x0008,
        SW_SHOWNOACTIVATE = 0x0004,
        SW_SHOWNORMAL = 0x0001,
        //Keyboard Input Notifications
        WM_ACTIVATE = 0x0006,
        WM_APPCOMMAND = 0x0319,
        WM_CHAR = 0x0102,
        WM_DEADCHAR = 0x0103,
        WM_HOTKEY = 0x0312,
        WM_KEYDOWN = 0x0100,
        WM_KEYUP = 0x0101,
        WM_KILLFOCUS = 0x0008,
        WM_SETFOCUS = 0x0007,
        WM_SYSDEADCHAR = 0x0107,
        WM_SYSKEYDOWN = 0x0104,
        WM_SYSKEYUP = 0x0105,
        WM_UNICHAR = 0x0109,
        //Mouse Input Notifications
        WM_CAPTURECHANGED = 0x0215,
        WM_LBUTTONDBLCLK = 0x0203,
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_MBUTTONDBLCLK = 0x0209,
        WM_MBUTTONDOWN = 0x0207,
        WM_MBUTTONUP = 0x0208,
        WM_MOUSEACTIVATE = 0x0021,
        WM_MOUSEHOVER = 0x02A1,
        WM_MOUSEHWHEEL = 0x020E,
        WM_MOUSELEAVE = 0x02A3,
        WM_MOUSEMOVE = 0x0200,
        WM_MOUSEWHEEL = 0x020A,
        WM_NCHITTEST = 0x0084,
        WM_NCLBUTTONDBLCLK = 0x00A3,
        WM_NCLBUTTONDOWN = 0x00A1,
        WM_NCLBUTTONUP = 0x00A2,
        WM_NCMBUTTONDBLCLK = 0x00A9,
        WM_NCMBUTTONDOWN = 0x00A7,
        WM_NCMBUTTONUP = 0x00A8,
        WM_NCMOUSEHOVER = 0x02A0,
        WM_NCMOUSELEAVE = 0x02A2,
        WM_NCMOUSEMOVE = 0x00A0,
        WM_NCRBUTTONDBLCLK = 0x00A6,
        WM_NCRBUTTONDOWN = 0x00A4,
        WM_NCRBUTTONUP = 0x00A5,
        WM_NCXBUTTONDBLCLK = 0x00AD,
        WM_NCXBUTTONDOWN = 0x00AB,
        WM_NCXBUTTONUP = 0x00AC,
        WM_RBUTTONDBLCLK = 0x0206,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_XBUTTONDBLCLK = 0x020D,
        WM_XBUTTONDOWN = 0x020B,
        WM_XBUTTONUP = 0x020C
    }

    public enum MapVirtualKeyMapTypes : uint
    {
        MAPVK_VK_TO_VSC = 0x00,
        MAPVK_VSC_TO_VK = 0x01,
        MAPVK_VK_TO_CHAR = 0x02,
        MAPVK_VSC_TO_VK_EX = 0x03,
        MAPVK_VK_TO_VSC_EX = 0x04
    }
}
