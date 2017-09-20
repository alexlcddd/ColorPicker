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
    public partial class AboutForm : MetroFramework.Forms.MetroForm
    {
        public AboutForm()
        {
            InitializeComponent();

            //Theme and style init
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = (MetroFramework.MetroThemeStyle)Properties.Settings.Default.ThemeIndex;
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)Properties.Settings.Default.ColorIndex;
        }

        private void metroLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jehokoa");
        }
    }
}
