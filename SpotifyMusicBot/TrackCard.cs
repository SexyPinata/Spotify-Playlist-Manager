using SpotifyAPI.Web.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.String;
using Cursor = System.Windows.Forms.Cursor;

namespace SpotifyMusicBot
{
    public partial class TrackCard : UserControl
    {
        private readonly FullTrack _track;

        public TrackCard(FullTrack track)
        {
            InitializeComponent();
            _track = track;
        }

        private void TrackCard_MouseHover(object sender, EventArgs e)
        {
            //radPopupEditor1.PopupForm.ShowPopup(new Rectangle(new Point(Cursor.Position.X,Cursor.Position.Y-radPopupContainer1.Height), new Size(radPopupContainer1.Width,radPopupContainer1.Height)));
            Console.WriteLine("hover");
        }

        private void TrackCard_DoubleClick(object sender, EventArgs e)
        {
            radPopupContainer1.Show();
            radPopupContainer1.Visible = true;
            radPopupContainer1.Enabled = true;
            radPopupEditor1.PopupEditorElement.ShowPopup();
            radPopupEditor1.PopupEditorElement.ClosePopup();
            radPopupEditor1.Popup.ShowPopup(new Rectangle(new Point(Cursor.Position.X, Cursor.Position.Y - radPopupContainer1.Height), new Size(radPopupContainer1.Width, radPopupContainer1.Height)));
            //radPopupEditor1.PopupForm.ShowPopup(new Rectangle(new Point(Cursor.Position.X, Cursor.Position.Y - radPopupContainer1.Height), new Size(radPopupContainer1.Width, radPopupContainer1.Height)));
            Console.WriteLine("Double click");
        }

        private void TrackCard_Load(object sender, EventArgs e)
        {
            var artistNameList = _track.Artists.Select(simpleArtist => simpleArtist.Name).ToList();
            radPopupEditor1.Hide();
            var fullTrackCard = new FullTrackCard
            {
                TrackName = { Text = _track.Name },
                Album = { Text = _track.Album.Name },
                ReleaseDate = { Text = _track.Album.ReleaseDate },
                Artist = { Text = Join(", ", artistNameList) },
                Popularity = { Value1 = _track.Popularity },
                label1 = { Text = Join(", ", Form1.GetGenres(_track)) }
            };
            fullTrackCard.pictureBox1.Load(AlbumImage.ImageLocation);
            radPopupContainer1.Controls.Add(fullTrackCard);
            radPopupContainer1.Size = fullTrackCard.Size;
            radPopupContainer1.AutoScroll = false;
        }
    }
}