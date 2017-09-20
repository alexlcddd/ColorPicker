using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorPicker
{
    class HotKey
    {
        #region WinAPI
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public enum KeyModifiers
        {
            None = 0x0000,
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Windows = 0x0008
        }
        #endregion

        public bool CreateHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk)
        {
            return RegisterHotKey(hWnd, id, (int)fsModifiers, (int)vk);
        }

        public bool DestroyHotKey(IntPtr hWnd, int id)
        {
            return UnregisterHotKey(hWnd, id);
        }
    }
}
