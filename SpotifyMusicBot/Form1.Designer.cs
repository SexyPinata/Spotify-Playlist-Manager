namespace SpotifyMusicBot
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
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.switchAddToSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(898, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnCreateAndSetPlaylists
            // 
            this.BtnCreateAndSetPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.TackListPanel.Location = new System.Drawing.Point(223, 12);
            this.TackListPanel.Name = "TackListPanel";
            this.TackListPanel.Size = new System.Drawing.Size(738, 621);
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
            this.PlaylistButton.Location = new System.Drawing.Point(107, 664);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Size = new System.Drawing.Size(110, 24);
            this.PlaylistButton.TabIndex = 6;
            this.PlaylistButton.Text = "radButton1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 690);
            this.Controls.Add(this.PlaylistButton);
            this.Controls.Add(this.PlaylistPanel);
            this.Controls.Add(this.switchAddToSpotify);
            this.Controls.Add(this.TackListPanel);
            this.Controls.Add(this.BtnCreateAndSetPlaylists);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.switchAddToSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistButton)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

