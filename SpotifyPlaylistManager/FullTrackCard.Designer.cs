namespace SpotifyPlaylistManager
{
    partial class FullTrackCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrackName = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Popularity = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popularity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrackName
            // 
            this.TrackName.AutoSize = true;
            this.TrackName.Location = new System.Drawing.Point(4, 263);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(63, 13);
            this.TrackName.TabIndex = 1;
            this.TrackName.Text = "TrackName";
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Location = new System.Drawing.Point(4, 276);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(30, 13);
            this.Artist.TabIndex = 2;
            this.Artist.Text = "Artist";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(4, 289);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(36, 13);
            this.Album.TabIndex = 3;
            this.Album.Text = "Album";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(5, 302);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(69, 13);
            this.ReleaseDate.TabIndex = 4;
            this.ReleaseDate.Text = "ReleaseDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Popularity
            // 
            this.Popularity.Location = new System.Drawing.Point(8, 485);
            this.Popularity.Name = "Popularity";
            this.Popularity.Size = new System.Drawing.Size(245, 24);
            this.Popularity.TabIndex = 6;
            this.Popularity.Text = "Popularity";
            this.Popularity.ThemeName = "TelerikMetro";
            this.Popularity.Value1 = 50;
            // 
            // FullTrackCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Popularity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FullTrackCard";
            this.Size = new System.Drawing.Size(256, 512);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popularity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label TrackName;
        public System.Windows.Forms.Label Artist;
        public System.Windows.Forms.Label Album;
        public System.Windows.Forms.Label ReleaseDate;
        public System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadProgressBar Popularity;
    }
}
