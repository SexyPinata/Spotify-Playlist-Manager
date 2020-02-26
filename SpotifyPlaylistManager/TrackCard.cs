using SpotifyAPI.Web.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static System.String;
using Cursor = System.Windows.Forms.Cursor;

namespace SpotifyPlaylistManager
{
    public partial class TrackCard : UserControl
    {
        #region Fields

        private readonly FullTrack _track;
        private FullTrackCard _fullTrackCard;

        #endregion Fields

        #region Constructors

        public TrackCard(FullTrack track)
        {
            InitializeComponent();
            _track = track;
        }

        #endregion Constructors

        #region Methods

        private void TrackCard_DoubleClick(object sender, EventArgs e)
        {
            if (radPopupContainer1.Controls.Count > 0)
            {
                radPopupContainer1.Controls.Clear();
            }
            radPopupContainer1.Controls.Add(_fullTrackCard);
            radPopupContainer1.Size = _fullTrackCard.Size;
            radPopupContainer1.AutoScroll = false;
            radPopupContainer1.Show();
            radPopupContainer1.Visible = true;
            radPopupContainer1.Enabled = true;
            radPopupEditor1.PopupEditorElement.ShowPopup();
            radPopupEditor1.PopupEditorElement.ClosePopup();
            radPopupEditor1.Popup.ShowPopup(new Rectangle(new Point(Cursor.Position.X, Cursor.Position.Y - radPopupContainer1.Height), new Size(radPopupContainer1.Width, radPopupContainer1.Height)));
            //radPopupEditor1.PopupForm.ShowPopup(new Rectangle(new Point(Cursor.Position.X, Cursor.Position.Y - radPopupContainer1.Height), new Size(radPopupContainer1.Width, radPopupContainer1.Height)));
            Console.WriteLine("Double click");
        }

        private async void TrackCard_Load(object sender, EventArgs e)
        {
            var artistNameList = _track.Artists.Select(simpleArtist => simpleArtist.Name).ToList();
            radPopupEditor1.Hide();
            try
            {
                _fullTrackCard = new FullTrackCard
                {
                    TrackName = { Text = _track.Name },
                    Album = { Text = _track.Album.Name },
                    ReleaseDate = { Text = _track.Album.ReleaseDate },
                    Artist = { Text = Join(", ", artistNameList) },
                    Popularity = { Value1 = _track.Popularity },
                    label1 = { Text = Join(", ", await SpotifyEasyApiHandler.GetGenresAsync(_track).ConfigureAwait(false)) }
                };
                _fullTrackCard.pictureBox1.LoadAsync(AlbumImage.ImageLocation);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        #endregion Methods
    }
}