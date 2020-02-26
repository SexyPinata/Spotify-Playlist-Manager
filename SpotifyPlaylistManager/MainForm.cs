using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPlaylistManager
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        #region Fields

        // White Space 1
        public List<FullTrack> TrackList = new List<FullTrack>();

        private static List<SongItem> _songItems;

        #endregion Fields

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Enums

        public enum Months { None, January, February, Mars, April, May, June, July, August, September, October, November, December };

        #endregion Enums

        #region Methods

        public async Task<Task> CreateTrackCardPanelAsync(PlaylistTrack track)
        {
            var trackCard = new TrackCard(track.Track);
            trackCard.AlbumImage.LoadAsync(track.Track.Album.Images.FirstOrDefault()?.Url);
            trackCard.TrackName.Text = track.Track.Name;

            TackListPanel.Controls.Add(trackCard);
            return Task.CompletedTask;
        }

        public Task CreateTrackCardPanelAsync(FullTrack track)
        {
            var trackCard = new TrackCard(track);
            trackCard.AlbumImage.LoadAsync(track.Album.Images.FirstOrDefault()?.Url);
            trackCard.TrackName.Text = track.Name;

            TackListPanel.Controls.Add(trackCard);
            return Task.CompletedTask;
        }

        private static void X_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = Color.LightGray;
        }

        private static void XOnMouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label) label.ForeColor = Color.GhostWhite;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FullTrack m = new FullTrack();
            CreateTrackCardPanelAsync(m);
        }

        private void BtnCreateAndSetPlaylists_Click(object sender, EventArgs e)
        {
            JsonHandler.SetMonthPlaylistId();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private Task DisplayPlaylistsSongsAsync(FullPlaylist playlist)
        {
            TackListPanel.Controls.Clear();
            var listOfTasks = playlist.Tracks.Items.Select(CreateTrackCardPanelAsync).ToList();

            return Task.WhenAll(listOfTasks);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            _songItems = await GenreReleaseHandler.Feed().ConfigureAwait(false);
            SpotifyEasyApiHandler.SpotifyInit();
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            PopulatePlaylists();
        }

        private void PopulatePlaylists()
        {
            var playlists = SpotifyEasyApiHandler.GetCurrentUsersPlaylists();
            if (playlists == null) return;
            foreach (var playlist in playlists.Items)
            {
                var x = new Label
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = Color.LightGray
                };
                x.Font = new Font(x.Font.Name, 12f, x.Font.Style, x.Font.Unit);
                x.AutoSize = false;
                x.Size = new Size(180, 30);
                x.MouseEnter += XOnMouseEnter;
                x.MouseLeave += X_MouseLeave;
                x.MouseDoubleClick += X_MouseDoubleClick;
                x.Text = playlist.Name;
                x.Name = playlist.Id;
                x.ContextMenuStrip = contextMenuStrip1;
                PlaylistPanel.Controls.Add(x);
            }
        }

        private async Task populateTrackCardPanelAsync()
        {
            TackListPanel.Controls.Clear();
        }

        private void Tes2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private async void X_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float acousticness = 0, danceability = 0, energy = 0, instrumentalness = 0, loudness = 0, valence = 0, tempo = 0;
            var plSender = sender as Label;
            var playlistId = plSender?.Name;
            var playlist = await SpotifyEasyApiHandler.Api.GetPlaylistAsync(playlistId).ConfigureAwait(true);
            await DisplayPlaylistsSongsAsync(playlist).ConfigureAwait(false);
            foreach (var item in Enum.GetValues(typeof(PlaylistInfoHelper.AudioFeature)))
            {
                switch (Convert.ToInt32(item))
                {
                    case 0:
                        acousticness =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Acousticness)
                                .ConfigureAwait(false);
                        break;

                    case 1:
                        danceability =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Danceability)
                                .ConfigureAwait(false);
                        DanceabilityProgress.Value1 = Convert.ToInt32(danceability);
                        break;

                    case 2:
                        energy =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Energy)
                                .ConfigureAwait(false);
                        EnergyProgress.Value1 = Convert.ToInt32(energy);
                        break;

                    case 3:
                        instrumentalness =
                            await PlaylistInfoHelper
                                .GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Instrumentalness)
                                .ConfigureAwait(false);
                        IntrumentalnessProgress.Value1 = Convert.ToInt32(instrumentalness);
                        break;

                    case 4:
                        loudness =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Loudness)
                                .ConfigureAwait(false);
                        LoudnessProgress.Value1 = Convert.ToInt32(loudness + 60);
                        break;

                    case 5:
                        valence =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Valence)
                                .ConfigureAwait(false);
                        ValenceProgress.Value1 = Convert.ToInt32(valence);
                        break;

                    case 6:
                        tempo =
                            await PlaylistInfoHelper.GetAverageAsync(playlist, PlaylistInfoHelper.AudioFeature.Tempo)
                                .ConfigureAwait(false);
                        TempProgress.Value1 = Convert.ToInt32(tempo);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(item), item, null);
                }
            }
            PlaylistInfo playlistInfo = new PlaylistInfo(acousticness, danceability, energy, instrumentalness, loudness, valence, tempo, default, playlist);
        }

        #endregion Methods

        private void DanceabilityLbl_Click(object sender, EventArgs e)
        {
        }

        private void EnergyLbl_Click(object sender, EventArgs e)
        {
        }

        private void InstrumentalnessLbl_Click(object sender, EventArgs e)
        {
        }

        private void LoudnessLbl_Click(object sender, EventArgs e)
        {
        }

        private void radCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
        }

        private void radCollapsiblePanel1_PanelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void radProgressBar1_Click(object sender, EventArgs e)
        {
        }

        private void radProgressBar2_Click(object sender, EventArgs e)
        {
        }

        private void radProgressBar3_Click(object sender, EventArgs e)
        {
        }

        private void radProgressBar4_Click(object sender, EventArgs e)
        {
        }

        private void radProgressBar5_Click(object sender, EventArgs e)
        {
        }

        private void TempoLbl_Click(object sender, EventArgs e)
        {
        }

        private void ValenceLbl_Click(object sender, EventArgs e)
        {
        }
    }
}