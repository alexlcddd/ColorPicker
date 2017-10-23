namespace ColorPicker
{
    partial class PreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ZoomLabel = new MetroFramework.Controls.MetroLabel();
            this.ZoomTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.HotkeyLabel = new MetroFramework.Controls.MetroLabel();
            this.ChangeHotkeyButton = new MetroFramework.Controls.MetroButton();
            this.OpacityLabel = new MetroFramework.Controls.MetroLabel();
            this.OpacityTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.mcbCopyFormat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mcbTheme
            // 
            this.mcbTheme.FormattingEnabled = true;
            this.mcbTheme.ItemHeight = 23;
            this.mcbTheme.Items.AddRange(new object[] {
            "Default",
            "Light",
            "Dark"});
            this.mcbTheme.Location = new System.Drawing.Point(23, 85);
            this.mcbTheme.Name = "mcbTheme";
            this.mcbTheme.Size = new System.Drawing.Size(121, 29);
            this.mcbTheme.TabIndex = 0;
            this.mcbTheme.UseSelectable = true;
            this.mcbTheme.SelectedIndexChanged += new System.EventHandler(this.mcbTheme_SelectedIndexChanged);
            // 
            // mcbColor
            // 
            this.mcbColor.FormattingEnabled = true;
            this.mcbColor.ItemHeight = 23;
            this.mcbColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.mcbColor.Location = new System.Drawing.Point(156, 85);
            this.mcbColor.Name = "mcbColor";
            this.mcbColor.Size = new System.Drawing.Size(121, 29);
            this.mcbColor.TabIndex = 1;
            this.mcbColor.UseSelectable = true;
            this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.mcbColor_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(156, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Color:";
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.Location = new System.Drawing.Point(23, 117);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(59, 19);
            this.ZoomLabel.TabIndex = 2;
            this.ZoomLabel.Text = "Zoom: 2";
            // 
            // ZoomTrackBar
            // 
            this.ZoomTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.ZoomTrackBar.Location = new System.Drawing.Point(23, 139);
            this.ZoomTrackBar.Maximum = 32;
            this.ZoomTrackBar.Minimum = 1;
            this.ZoomTrackBar.Name = "ZoomTrackBar";
            this.ZoomTrackBar.Size = new System.Drawing.Size(254, 23);
            this.ZoomTrackBar.TabIndex = 3;
            this.ZoomTrackBar.Text = "metroTrackBar1";
            this.ZoomTrackBar.Value = 2;
            this.ZoomTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZoomTrackBar_Scroll);
            // 
            // HotkeyLabel
            // 
            this.HotkeyLabel.AutoSize = true;
            this.HotkeyLabel.Location = new System.Drawing.Point(23, 272);
            this.HotkeyLabel.Name = "HotkeyLabel";
            this.HotkeyLabel.Size = new System.Drawing.Size(97, 19);
            this.HotkeyLabel.TabIndex = 4;
            this.HotkeyLabel.Text = "Hotkey: Alt + X";
            // 
            // ChangeHotkeyButton
            // 
            this.ChangeHotkeyButton.Location = new System.Drawing.Point(23, 294);
            this.ChangeHotkeyButton.Name = "ChangeHotkeyButton";
            this.ChangeHotkeyButton.Size = new System.Drawing.Size(254, 23);
            this.ChangeHotkeyButton.TabIndex = 5;
            this.ChangeHotkeyButton.Text = "Change hotkey";
            this.ChangeHotkeyButton.UseSelectable = true;
            this.ChangeHotkeyButton.Click += new System.EventHandler(this.ChangeHotkeyButton_Click);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(23, 165);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(91, 19);
            this.OpacityLabel.TabIndex = 2;
            this.OpacityLabel.Text = "Opacity: 100%";
            // 
            // OpacityTrackBar
            // 
            this.OpacityTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.OpacityTrackBar.Location = new System.Drawing.Point(23, 187);
            this.OpacityTrackBar.Minimum = 10;
            this.OpacityTrackBar.Name = "OpacityTrackBar";
            this.OpacityTrackBar.Size = new System.Drawing.Size(254, 23);
            this.OpacityTrackBar.TabIndex = 3;
            this.OpacityTrackBar.Text = "OpacityTrackBar";
            this.OpacityTrackBar.Value = 100;
            this.OpacityTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OpacityTrackBar_Scroll);
            // 
            // mcbCopyFormat
            // 
            this.mcbCopyFormat.FormattingEnabled = true;
            this.mcbCopyFormat.ItemHeight = 23;
            this.mcbCopyFormat.Items.AddRange(new object[] {
            "HEX (FFFFFF)",
            "#HEX (#FFFFFF)",
            "r g b (255 255 255)",
            "r, g, b (255, 255, 255)",
            "CMYK (1.00, 1.00, 1.00, 1.00)"});
            this.mcbCopyFormat.Location = new System.Drawing.Point(23, 235);
            this.mcbCopyFormat.Name = "mcbCopyFormat";
            this.mcbCopyFormat.Size = new System.Drawing.Size(254, 29);
            this.mcbCopyFormat.TabIndex = 0;
            this.mcbCopyFormat.UseSelectable = true;
            this.mcbCopyFormat.SelectedIndexChanged += new System.EventHandler(this.mcbCopyFormat_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Copy format:";
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 340);
            this.Controls.Add(this.ChangeHotkeyButton);
            this.Controls.Add(this.HotkeyLabel);
            this.Controls.Add(this.OpacityTrackBar);
            this.Controls.Add(this.ZoomTrackBar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.OpacityLabel);
            this.Controls.Add(this.ZoomLabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbCopyFormat);
            this.Controls.Add(this.mcbColor);
            this.Controls.Add(this.mcbTheme);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PreferencesForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Preferences";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroComboBox mcbTheme;
        private MetroFramework.Controls.MetroComboBox mcbColor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel ZoomLabel;
        private MetroFramework.Controls.MetroTrackBar ZoomTrackBar;
        private MetroFramework.Controls.MetroButton ChangeHotkeyButton;
        private MetroFramework.Controls.MetroLabel HotkeyLabel;
        private MetroFramework.Controls.MetroTrackBar OpacityTrackBar;
        private MetroFramework.Controls.MetroLabel OpacityLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mcbCopyFormat;
    }
}