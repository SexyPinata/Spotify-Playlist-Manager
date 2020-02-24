namespace SpotifyPlaylistManager
{
    partial class TrackCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            this.AlbumImage = new System.Windows.Forms.PictureBox();
            this.TrackName = new System.Windows.Forms.Label();
            this.radPopupEditor1 = new Telerik.WinControls.UI.RadPopupEditor();
            this.radPopupContainer1 = new Telerik.WinControls.UI.RadPopupContainer();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).BeginInit();
            this.radPopupContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumImage
            // 
            this.AlbumImage.Location = new System.Drawing.Point(0, 0);
            this.AlbumImage.Name = "AlbumImage";
            this.AlbumImage.Size = new System.Drawing.Size(160, 160);
            this.AlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumImage.TabIndex = 0;
            this.AlbumImage.TabStop = false;
            this.AlbumImage.DoubleClick += new System.EventHandler(this.TrackCard_DoubleClick);
            // 
            // TrackName
            // 
            this.TrackName.AutoSize = true;
            this.TrackName.Location = new System.Drawing.Point(4, 167);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(35, 13);
            this.TrackName.TabIndex = 1;
            this.TrackName.Text = "label1";
            this.TrackName.DoubleClick += new System.EventHandler(this.TrackCard_DoubleClick);
            // 
            // radPopupEditor1
            // 
            this.radPopupEditor1.AssociatedControl = this.radPopupContainer1;
            this.radPopupEditor1.BackColor = System.Drawing.Color.Transparent;
            this.radPopupEditor1.ForeColor = System.Drawing.Color.Transparent;
            this.radPopupEditor1.Location = new System.Drawing.Point(3, 212);
            this.radPopupEditor1.Name = "radPopupEditor1";
            // 
            // 
            // 
            this.radPopupEditor1.RootElement.ClickMode = Telerik.WinControls.ClickMode.Hover;
            this.radPopupEditor1.ShowTextBox = false;
            this.radPopupEditor1.Size = new System.Drawing.Size(125, 24);
            this.radPopupEditor1.TabIndex = 2;
            this.radPopupEditor1.Text = "radPopupEditor1";
            this.radPopupEditor1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPopupEditorElement)(this.radPopupEditor1.GetChildAt(0))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPopupEditorElement)(this.radPopupEditor1.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPopupEditorElement)(this.radPopupEditor1.GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Hover;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(0))).BottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(0))).ForeColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(0))).ForeColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(0))).ForeColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Text = "radPopupEditor1";
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).ClickMode = Telerik.WinControls.ClickMode.Hover;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPopupEditor1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(5))).LineLimit = false;
            // 
            // radPopupContainer1
            // 
            this.radPopupContainer1.Location = new System.Drawing.Point(144, 197);
            this.radPopupContainer1.Name = "radPopupContainer1";
            // 
            // radPopupContainer1.PanelContainer
            // 
            this.radPopupContainer1.PanelContainer.Size = new System.Drawing.Size(254, 510);
            this.radPopupContainer1.Size = new System.Drawing.Size(256, 512);
            this.radPopupContainer1.TabIndex = 3;
            // 
            // radThemeManager1
            // 
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1});
            // 
            // TrackCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPopupContainer1);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.AlbumImage);
            this.Controls.Add(this.radPopupEditor1);
            this.Name = "TrackCard";
            this.Size = new System.Drawing.Size(160, 235);
            this.Load += new System.EventHandler(this.TrackCard_Load);
            this.DoubleClick += new System.EventHandler(this.TrackCard_DoubleClick);
            this.MouseHover += new System.EventHandler(this.TrackCard_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).EndInit();
            this.radPopupContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox AlbumImage;
        public System.Windows.Forms.Label TrackName;
        private Telerik.WinControls.UI.RadPopupEditor radPopupEditor1;
        private Telerik.WinControls.UI.RadPopupContainer radPopupContainer1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}
