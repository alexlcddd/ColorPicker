using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        #region InitVariables
        private Bitmap bmp;
        private Graphics gfx;
        private Color clr;

        private static IntPtr _hWnd;
        public static IntPtr hWnd
        { get => _hWnd; set => _hWnd = value; }

        private static HotKey _hotkey;
        public static HotKey hotkey
        { get => _hotkey; set => _hotkey = value; }

        private static HotKey.KeyModifiers _fsModifiers;
        public static HotKey.KeyModifiers fsModifiers
        { get => _fsModifiers; set => _fsModifiers = value; }

        private static Keys _vk;
        public static Keys vk
        { get => _vk; set => _vk = value; }

        private static int _zoom = 2;
        public static int zoom
        { get => _zoom; set => _zoom = value; }

        private static double _opacity = 1;
        public static double opacity
        { get => _opacity; set => _opacity = value; }

        private static MetroFramework.Components.MetroStyleManager _styleManager;
        public static MetroFramework.Components.MetroStyleManager styleManager
        { get => _styleManager; set => _styleManager = value; }
        #endregion

        public Form1()
        {
            InitializeComponent();
            hWnd = this.Handle;

            //Hotkeys init
            fsModifiers = (HotKey.KeyModifiers)Properties.Settings.Default.KeyModifier;
            vk = (Keys)Properties.Settings.Default.KeyCode;
            hotkey = new HotKey();
            hotkey.CreateHotKey(hWnd, 0, (int)_fsModifiers, (int)_vk);

            //Theme and style init
            this.StyleManager = metroStyleManager;
            styleManager = this.StyleManager;
            styleManager.Theme = (MetroFramework.MetroThemeStyle)Properties.Settings.Default.ThemeIndex;
            styleManager.Style = (MetroFramework.MetroColorStyle)Properties.Settings.Default.ColorIndex;

            //Zoom init
            zoom = Properties.Settings.Default.Zoom;

            //Opacity init
            opacity = Properties.Settings.Default.Opacity;
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            //Capture
            bmp = new Bitmap(CapturePanel.Width / zoom, CapturePanel.Height / zoom, PixelFormat.Format32bppArgb);
            gfx = Graphics.FromImage(bmp);
            gfx.CopyFromScreen(MousePosition.X - CapturePanel.Width / (zoom * 2),
                MousePosition.Y - CapturePanel.Height / (zoom * 2), 0, 0, CapturePanel.Size, CopyPixelOperation.SourceCopy);
            CapturePanel.BackgroundImage = bmp;
            clr = bmp.GetPixel(CapturePanel.Width / (zoom * 2), CapturePanel.Height / (zoom * 2));

            //Panel
            ColorPanel.BackColor = clr;

            //Labels
            ColorRgbLabel.Text = clr.R.ToString() + ", " + clr.G.ToString() + ", " + clr.B.ToString();
            ColorHexLabel.Text = "#" + clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
            CursorPositionLabel.Text = "[" + MousePosition.X.ToString() + ", " + MousePosition.Y.ToString() + "]";

            //Opacity
            this.Opacity = opacity;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
                Clipboard.SetText(ColorHexLabel.Text);
            base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hotkey.DestroyHotKey(hWnd, 0);
        }
    }
}
