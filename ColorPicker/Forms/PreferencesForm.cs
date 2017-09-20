using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class PreferencesForm : MetroFramework.Forms.MetroForm
    {
        int fsModifiers = 0;
        int vk = 0;
        bool isRecordingKeys = false;

        public PreferencesForm()
        {
            InitializeComponent();

            //Theme and style init
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = (MetroFramework.MetroThemeStyle)Properties.Settings.Default.ThemeIndex;
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)Properties.Settings.Default.ColorIndex;
            mcbTheme.SelectedIndex = Properties.Settings.Default.ThemeIndex;
            mcbColor.SelectedIndex = Properties.Settings.Default.ColorIndex;

            //TrackBars init
            ZoomTrackBar.Value = Properties.Settings.Default.Zoom;
            ZoomLabel.Text = "Zoom: " + ZoomTrackBar.Value;
            OpacityTrackBar.Value = (int)(Properties.Settings.Default.Opacity * 100);
            OpacityLabel.Text = "Opacity: " + OpacityTrackBar.Value + "%";

            //Hotkey label
            fsModifiers = Properties.Settings.Default.KeyModifier;
            vk = Properties.Settings.Default.KeyCode;
            HotkeyLabel.Text = "Hotkey: "
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Alt) != 0) ? "Alt + " : "")
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Control) != 0) ? "Ctrl + " : "")
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Shift) != 0) ? "Shift + " : "")
                    + (Keys)vk;
        }

        private void mcbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager.Theme = (MetroFramework.MetroThemeStyle)(mcbTheme.SelectedIndex);
            Form1.styleManager.Theme = (MetroFramework.MetroThemeStyle)(mcbTheme.SelectedIndex);
            Properties.Settings.Default.ThemeIndex = mcbTheme.SelectedIndex;
        }

        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)(mcbColor.SelectedIndex);
            Form1.styleManager.Style = (MetroFramework.MetroColorStyle)(mcbColor.SelectedIndex);
            Properties.Settings.Default.ColorIndex = mcbColor.SelectedIndex;
        }

        private void ZoomTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            Form1.zoom = ZoomTrackBar.Value;
            ZoomLabel.Text = "Zoom: " + ZoomTrackBar.Value;
            Properties.Settings.Default.Zoom = ZoomTrackBar.Value;
        }

        private void OpacityTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            Form1.opacity = (double)OpacityTrackBar.Value / 100;
            OpacityLabel.Text = "Opacity: " + OpacityTrackBar.Value + "%";
            Properties.Settings.Default.Opacity = (double)OpacityTrackBar.Value / 100;
        }

        private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void ChangeHotkeyButton_Click(object sender, EventArgs e)
        {
            fsModifiers = 0;
            vk = 0;
            HotkeyLabel.Focus();
            HotkeyLabel.Text = "Hotkey: press your hotkey";
            isRecordingKeys = true;
        }

        private void SaveHotKey()
        {
            Form1.fsModifiers = (HotKey.KeyModifiers)fsModifiers;
            Form1.vk = (Keys)vk;

            Properties.Settings.Default.KeyModifier = fsModifiers;
            Properties.Settings.Default.KeyCode = vk;

            Form1.hotkey.CreateHotKey(Form1.hWnd, 0, fsModifiers, vk);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (isRecordingKeys)
            {
                if (e.Alt || e.Control || e.Shift)
                {
                    if (e.Alt)
                        fsModifiers |= (int)HotKey.KeyModifiers.Alt;
                    if (e.Control)
                        fsModifiers |= (int)HotKey.KeyModifiers.Control;
                    if (e.Shift)
                        fsModifiers |= (int)HotKey.KeyModifiers.Shift;
                }
                else
                { 
                    vk = (int)e.KeyCode;
                    isRecordingKeys = false;
                    SaveHotKey();
                }

                HotkeyLabel.Text = "Hotkey: "
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Alt) != 0) ? "Alt + " : "")
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Control) != 0) ? "Ctrl + " : "")
                    + (((fsModifiers & (int)HotKey.KeyModifiers.Shift) != 0) ? "Shift + " : "")
                    + (Keys)vk;
            }

            base.OnKeyDown(e);
        }
    }
}
