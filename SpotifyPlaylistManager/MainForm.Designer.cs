namespace SpotifyPlaylistManager
{
    partial class MainForm
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
            this.BtnCreateAndSetPlaylists = new System.Windows.Forms.Button();
            this.TackListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.switchAddToSpotify = new Telerik.WinControls.UI.RadToggleSwitch();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.crystalDarkTheme2 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.PlaylistPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlaylistButton = new Telerik.WinControls.UI.RadButton();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tes2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tes3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IntrumentalnessProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.ValenceProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.DanceabilityProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.CollapsablePlaylistInfoPanel = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.DanceabilityLbl = new System.Windows.Forms.Label();
            this.EnergyLbl = new System.Windows.Forms.Label();
            this.InstrumentalnessLbl = new System.Windows.Forms.Label();
            this.ValenceLbl = new System.Windows.Forms.Label();
            this.TempoLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EnergyProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.TempProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.LoudnessProgress = new Telerik.WinControls.UI.RadProgressBar();
            this.LoudnessLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.switchAddToSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntrumentalnessProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValenceProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapsablePlaylistInfoPanel)).BeginInit();
            this.CollapsablePlaylistInfoPanel.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoudnessProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateAndSetPlaylists
            // 
            this.BtnCreateAndSetPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCreateAndSetPlaylists.Enabled = false;
            this.BtnCreateAndSetPlaylists.Location = new System.Drawing.Point(3, 665);
            this.BtnCreateAndSetPlaylists.Name = "BtnCreateAndSetPlaylists";
            this.BtnCreateAndSetPlaylists.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateAndSetPlaylists.TabIndex = 1;
            this.BtnCreateAndSetPlaylists.Text = "Set";
            this.BtnCreateAndSetPlaylists.UseVisualStyleBackColor = true;
            this.BtnCreateAndSetPlaylists.Click += new System.EventHandler(this.BtnCreateAndSetPlaylists_Click);
            // 
            // TackListPanel
            // 
            this.TackListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TackListPanel.AutoScroll = true;
            this.TackListPanel.Location = new System.Drawing.Point(223, 25);
            this.TackListPanel.Name = "TackListPanel";
            this.TackListPanel.Size = new System.Drawing.Size(738, 608);
            this.TackListPanel.TabIndex = 2;
            // 
            // switchAddToSpotify
            // 
            this.switchAddToSpotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.switchAddToSpotify.Location = new System.Drawing.Point(911, 639);
            this.switchAddToSpotify.Name = "switchAddToSpotify";
            this.switchAddToSpotify.Size = new System.Drawing.Size(50, 20);
            this.switchAddToSpotify.TabIndex = 4;
            this.switchAddToSpotify.ThemeName = "VisualStudio2012Dark";
            this.switchAddToSpotify.ThumbTickness = 15;
            // 
            // PlaylistPanel
            // 
            this.PlaylistPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PlaylistPanel.AutoScroll = true;
            this.PlaylistPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlaylistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.PlaylistPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlaylistPanel.Location = new System.Drawing.Point(3, 12);
            this.PlaylistPanel.Name = "PlaylistPanel";
            this.PlaylistPanel.Size = new System.Drawing.Size(214, 621);
            this.PlaylistPanel.TabIndex = 5;
            this.PlaylistPanel.WrapContents = false;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlaylistButton.Location = new System.Drawing.Point(851, 664);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(110, 24);
            this.PlaylistButton.TabIndex = 6;
            this.PlaylistButton.Text = "Get Playlists";
            this.PlaylistButton.ThemeName = "VisualStudio2012Dark";
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.tes2ToolStripMenuItem,
            this.tes3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // tes2ToolStripMenuItem
            // 
            this.tes2ToolStripMenuItem.Name = "tes2ToolStripMenuItem";
            this.tes2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.tes2ToolStripMenuItem.Text = "tes2";
            this.tes2ToolStripMenuItem.Click += new System.EventHandler(this.Tes2ToolStripMenuItem_Click);
            // 
            // tes3ToolStripMenuItem
            // 
            this.tes3ToolStripMenuItem.Name = "tes3ToolStripMenuItem";
            this.tes3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.tes3ToolStripMenuItem.Text = "tes3";
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuButtonItem1});
            this.radContextMenu1.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "radMenuItem1";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "radMenuButtonItem1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // IntrumentalnessProgress
            // 
            this.IntrumentalnessProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.IntrumentalnessProgress.Location = new System.Drawing.Point(232, 260);
            this.IntrumentalnessProgress.Name = "IntrumentalnessProgress";
            this.IntrumentalnessProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.IntrumentalnessProgress.Size = new System.Drawing.Size(29, 136);
            this.IntrumentalnessProgress.TabIndex = 1;
            this.IntrumentalnessProgress.ThemeName = "VisualStudio2012Dark";
            this.IntrumentalnessProgress.Click += new System.EventHandler(this.radProgressBar2_Click);
            // 
            // ValenceProgress
            // 
            this.ValenceProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ValenceProgress.Location = new System.Drawing.Point(396, 260);
            this.ValenceProgress.Name = "ValenceProgress";
            this.ValenceProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.ValenceProgress.Size = new System.Drawing.Size(29, 136);
            this.ValenceProgress.TabIndex = 1;
            this.ValenceProgress.ThemeName = "VisualStudio2012Dark";
            this.ValenceProgress.Click += new System.EventHandler(this.radProgressBar3_Click);
            // 
            // DanceabilityProgress
            // 
            this.DanceabilityProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.DanceabilityProgress.Location = new System.Drawing.Point(68, 260);
            this.DanceabilityProgress.Name = "DanceabilityProgress";
            this.DanceabilityProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.DanceabilityProgress.Size = new System.Drawing.Size(29, 136);
            this.DanceabilityProgress.TabIndex = 0;
            this.DanceabilityProgress.ThemeName = "VisualStudio2012Dark";
            this.DanceabilityProgress.Click += new System.EventHandler(this.radProgressBar1_Click);
            // 
            // CollapsablePlaylistInfoPanel
            // 
            this.CollapsablePlaylistInfoPanel.Location = new System.Drawing.Point(223, 12);
            this.CollapsablePlaylistInfoPanel.Name = "CollapsablePlaylistInfoPanel";
            this.CollapsablePlaylistInfoPanel.OwnerBoundsCache = new System.Drawing.Rectangle(223, 12, 738, 453);
            // 
            // CollapsablePlaylistInfoPanel.PanelContainer
            // 
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.LoudnessProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.LoudnessLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.EnergyProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.TempProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.label8);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.label7);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.label6);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.TempoLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.ValenceLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.InstrumentalnessLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.EnergyLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.DanceabilityLbl);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.IntrumentalnessProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.DanceabilityProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Controls.Add(this.ValenceProgress);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Size = new System.Drawing.Size(736, 425);
            this.CollapsablePlaylistInfoPanel.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.radCollapsiblePanel1_PanelContainer_Paint);
            this.CollapsablePlaylistInfoPanel.Size = new System.Drawing.Size(738, 453);
            this.CollapsablePlaylistInfoPanel.TabIndex = 7;
            this.CollapsablePlaylistInfoPanel.ThemeName = "VisualStudio2012Dark";
            this.CollapsablePlaylistInfoPanel.Expanded += new System.EventHandler(this.radCollapsiblePanel1_Expanded);
            // 
            // DanceabilityLbl
            // 
            this.DanceabilityLbl.AutoSize = true;
            this.DanceabilityLbl.ForeColor = System.Drawing.Color.White;
            this.DanceabilityLbl.Location = new System.Drawing.Point(47, 408);
            this.DanceabilityLbl.Name = "DanceabilityLbl";
            this.DanceabilityLbl.Size = new System.Drawing.Size(70, 13);
            this.DanceabilityLbl.TabIndex = 2;
            this.DanceabilityLbl.Text = "Danceability";
            this.DanceabilityLbl.Click += new System.EventHandler(this.DanceabilityLbl_Click);
            // 
            // EnergyLbl
            // 
            this.EnergyLbl.AutoSize = true;
            this.EnergyLbl.ForeColor = System.Drawing.Color.White;
            this.EnergyLbl.Location = new System.Drawing.Point(143, 408);
            this.EnergyLbl.Name = "EnergyLbl";
            this.EnergyLbl.Size = new System.Drawing.Size(42, 13);
            this.EnergyLbl.TabIndex = 3;
            this.EnergyLbl.Text = "Energy";
            this.EnergyLbl.Click += new System.EventHandler(this.EnergyLbl_Click);
            // 
            // InstrumentalnessLbl
            // 
            this.InstrumentalnessLbl.AutoSize = true;
            this.InstrumentalnessLbl.ForeColor = System.Drawing.Color.White;
            this.InstrumentalnessLbl.Location = new System.Drawing.Point(199, 408);
            this.InstrumentalnessLbl.Name = "InstrumentalnessLbl";
            this.InstrumentalnessLbl.Size = new System.Drawing.Size(95, 13);
            this.InstrumentalnessLbl.TabIndex = 4;
            this.InstrumentalnessLbl.Text = "Instrumentalness";
            this.InstrumentalnessLbl.Click += new System.EventHandler(this.InstrumentalnessLbl_Click);
            // 
            // ValenceLbl
            // 
            this.ValenceLbl.AutoSize = true;
            this.ValenceLbl.ForeColor = System.Drawing.Color.White;
            this.ValenceLbl.Location = new System.Drawing.Point(387, 408);
            this.ValenceLbl.Name = "ValenceLbl";
            this.ValenceLbl.Size = new System.Drawing.Size(46, 13);
            this.ValenceLbl.TabIndex = 5;
            this.ValenceLbl.Text = "Valence";
            this.ValenceLbl.Click += new System.EventHandler(this.ValenceLbl_Click);
            // 
            // TempoLbl
            // 
            this.TempoLbl.AutoSize = true;
            this.TempoLbl.ForeColor = System.Drawing.Color.White;
            this.TempoLbl.Location = new System.Drawing.Point(472, 408);
            this.TempoLbl.Name = "TempoLbl";
            this.TempoLbl.Size = new System.Drawing.Size(41, 13);
            this.TempoLbl.TabIndex = 6;
            this.TempoLbl.Text = "Tempo";
            this.TempoLbl.Click += new System.EventHandler(this.TempoLbl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // EnergyProgress
            // 
            this.EnergyProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.EnergyProgress.Location = new System.Drawing.Point(150, 260);
            this.EnergyProgress.Name = "EnergyProgress";
            this.EnergyProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.EnergyProgress.Size = new System.Drawing.Size(29, 136);
            this.EnergyProgress.TabIndex = 2;
            this.EnergyProgress.ThemeName = "VisualStudio2012Dark";
            this.EnergyProgress.Click += new System.EventHandler(this.radProgressBar4_Click);
            // 
            // TempProgress
            // 
            this.TempProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.TempProgress.Location = new System.Drawing.Point(478, 260);
            this.TempProgress.Maximum = 300;
            this.TempProgress.Name = "TempProgress";
            this.TempProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.TempProgress.Size = new System.Drawing.Size(29, 136);
            this.TempProgress.TabIndex = 2;
            this.TempProgress.ThemeName = "VisualStudio2012Dark";
            this.TempProgress.Click += new System.EventHandler(this.radProgressBar5_Click);
            // 
            // LoudnessProgress
            // 
            this.LoudnessProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.LoudnessProgress.Location = new System.Drawing.Point(314, 260);
            this.LoudnessProgress.Maximum = 60;
            this.LoudnessProgress.Name = "LoudnessProgress";
            this.LoudnessProgress.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom;
            this.LoudnessProgress.Size = new System.Drawing.Size(29, 136);
            this.LoudnessProgress.TabIndex = 7;
            this.LoudnessProgress.ThemeName = "VisualStudio2012Dark";
            // 
            // LoudnessLbl
            // 
            this.LoudnessLbl.AutoSize = true;
            this.LoudnessLbl.ForeColor = System.Drawing.Color.White;
            this.LoudnessLbl.Location = new System.Drawing.Point(300, 408);
            this.LoudnessLbl.Name = "LoudnessLbl";
            this.LoudnessLbl.Size = new System.Drawing.Size(56, 13);
            this.LoudnessLbl.TabIndex = 8;
            this.LoudnessLbl.Text = "Loudness";
            this.LoudnessLbl.Click += new System.EventHandler(this.LoudnessLbl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 690);
            this.Controls.Add(this.CollapsablePlaylistInfoPanel);
            this.Controls.Add(this.PlaylistButton);
            this.Controls.Add(this.PlaylistPanel);
            this.Controls.Add(this.switchAddToSpotify);
            this.Controls.Add(this.TackListPanel);
            this.Controls.Add(this.BtnCreateAndSetPlaylists);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainForm";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.switchAddToSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntrumentalnessProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValenceProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityProgress)).EndInit();
            this.CollapsablePlaylistInfoPanel.PanelContainer.ResumeLayout(false);
            this.CollapsablePlaylistInfoPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollapsablePlaylistInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoudnessProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateAndSetPlaylists;
        public System.Windows.Forms.FlowLayoutPanel TackListPanel;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadToggleSwitch switchAddToSpotify;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme2;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.FlowLayoutPanel PlaylistPanel;
        private Telerik.WinControls.UI.RadButton PlaylistButton;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tes2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tes3ToolStripMenuItem;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadProgressBar DanceabilityProgress;
        private Telerik.WinControls.UI.RadProgressBar IntrumentalnessProgress;
        private Telerik.WinControls.UI.RadProgressBar ValenceProgress;
        private Telerik.WinControls.UI.RadCollapsiblePanel CollapsablePlaylistInfoPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TempoLbl;
        private System.Windows.Forms.Label ValenceLbl;
        private System.Windows.Forms.Label InstrumentalnessLbl;
        private System.Windows.Forms.Label EnergyLbl;
        private System.Windows.Forms.Label DanceabilityLbl;
        private Telerik.WinControls.UI.RadProgressBar EnergyProgress;
        private Telerik.WinControls.UI.RadProgressBar TempProgress;
        private Telerik.WinControls.UI.RadProgressBar LoudnessProgress;
        private System.Windows.Forms.Label LoudnessLbl;
    }
}

