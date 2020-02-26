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
            var plSender = sender as Label;
            var playlistId = plSender?.Name;
            var playlist = await SpotifyEasyApiHandler.Api.GetPlaylistAsync(playlistId).ConfigureAwait(true);
            await DisplayPlaylistsSongsAsync(playlist).ConfigureAwait(false);
        }

        #endregion Methods
    }
}