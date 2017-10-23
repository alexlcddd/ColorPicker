namespace ColorPicker
{
    partial class Form1
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
            this.CapturePanel = new MetroFramework.Controls.MetroPanel();
            this.ColorPanel = new MetroFramework.Controls.MetroPanel();
            this.CursorPositionLabel = new MetroFramework.Controls.MetroLabel();
            this.ColorHexLabel = new MetroFramework.Controls.MetroLabel();
            this.ColorRgbLabel = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // CapturePanel
            // 
            this.CapturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CapturePanel.HorizontalScrollbarBarColor = true;
            this.CapturePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CapturePanel.HorizontalScrollbarSize = 10;
            this.CapturePanel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CapturePanel.Location = new System.Drawing.Point(0, 5);
            this.CapturePanel.Name = "CapturePanel";
            this.CapturePanel.Size = new System.Drawing.Size(80, 80);
            this.CapturePanel.TabIndex = 0;
            this.CapturePanel.VerticalScrollbarBarColor = true;
            this.CapturePanel.VerticalScrollbarHighlightOnWheel = false;
            this.CapturePanel.VerticalScrollbarSize = 10;
            this.CapturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragging);
            this.CapturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.CapturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorPanel.HorizontalScrollbarBarColor = true;
            this.ColorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ColorPanel.HorizontalScrollbarSize = 10;
            this.ColorPanel.Location = new System.Drawing.Point(86, 5);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(35, 80);
            this.ColorPanel.TabIndex = 0;
            this.ColorPanel.UseCustomBackColor = true;
            this.ColorPanel.VerticalScrollbarBarColor = true;
            this.ColorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ColorPanel.VerticalScrollbarSize = 10;
            this.ColorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragging);
            this.ColorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.ColorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // CursorPositionLabel
            // 
            this.CursorPositionLabel.AutoSize = true;
            this.CursorPositionLabel.Location = new System.Drawing.Point(123, 7);
            this.CursorPositionLabel.Name = "CursorPositionLabel";
            this.CursorPositionLabel.Size = new System.Drawing.Size(54, 19);
            this.CursorPositionLabel.TabIndex = 1;
            this.CursorPositionLabel.Text = "Position";
            this.CursorPositionLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragging);
            this.CursorPositionLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.CursorPositionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // ColorHexLabel
            // 
            this.ColorHexLabel.AutoSize = true;
            this.ColorHexLabel.Location = new System.Drawing.Point(123, 46);
            this.ColorHexLabel.Name = "ColorHexLabel";
            this.ColorHexLabel.Size = new System.Drawing.Size(67, 19);
            this.ColorHexLabel.TabIndex = 1;
            this.ColorHexLabel.Text = "HeX color";
            this.ColorHexLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragging);
            this.ColorHexLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.ColorHexLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // ColorRgbLabel
            // 
            this.ColorRgbLabel.AutoSize = true;
            this.ColorRgbLabel.Location = new System.Drawing.Point(123, 63);
            this.ColorRgbLabel.Name = "ColorRgbLabel";
            this.ColorRgbLabel.Size = new System.Drawing.Size(68, 19);
            this.ColorRgbLabel.TabIndex = 1;
            this.ColorRgbLabel.Text = "RGB color";
            this.ColorRgbLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDragging);
            this.ColorRgbLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            this.ColorRgbLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Enabled = true;
            this.CaptureTimer.Interval = 25;
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 85);
            this.ContextMenuStrip = this.metroContextMenu;
            this.Controls.Add(this.ColorRgbLabel);
            this.Controls.Add(this.ColorHexLabel);
            this.Controls.Add(this.CursorPositionLabel);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.CapturePanel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.2D;
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "fsd";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.metroContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel CapturePanel;
        private MetroFramework.Controls.MetroPanel ColorPanel;
        private MetroFramework.Controls.MetroLabel CursorPositionLabel;
        private MetroFramework.Controls.MetroLabel ColorHexLabel;
        private MetroFramework.Controls.MetroLabel ColorRgbLabel;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer CaptureTimer;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}

