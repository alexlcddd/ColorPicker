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
        public PreferencesForm()
        {
            InitializeComponent();

            //Theme and style init
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = (MetroFramework.MetroThemeStyle)Properties.Settings.Default.ThemeIndex;
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)Properties.Settings.Default.ColorIndex;
            mcbTheme.SelectedIndex = Properties.Settings.Default.ThemeIndex;
            mcbColor.SelectedIndex = Properties.Settings.Default.ColorIndex;

            //TrackBar init
            ZoomTrackBar.Value = Properties.Settings.Default.Zoom;
            ZoomLabel.Text = "Zoom: " + ZoomTrackBar.Value;
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

        private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
