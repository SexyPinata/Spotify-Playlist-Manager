using CodeHollow.FeedReader;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = SpotifyAPI.Web.Models.Image;

namespace SpotifyPlaylistManager
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public static SpotifyWebAPI Api = new SpotifyWebAPI();

        public static string UserId;

        private const string ClientId = "0b77d4294b49451bba2571fa3d09ae46";

        private static List<SongItem> _songItems;

        // White Space 1
        public List<FullTrack> TrackList = new List<FullTrack>();

        public MainForm()
        {
            InitializeComponent();
        }

        public enum Months { None, January, February, Mars, April, May, June, July, August, September, October, November, December };

        public static async Task<FullTrack> GetFullTrackAsync(string searchTerm)
        {
            var item = await Api.SearchItemsAsync(searchTerm.Replace("#", ""), SearchType.All).ConfigureAwait(false);
            Console.WriteLine(@"Searched for: " + searchTerm);
            try
            {
                item.Tracks.Items.Sort();
                Console.WriteLine(item.Tracks.Items.FirstOrDefault()?.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return
                item.Tracks.Items.FirstOrDefault(); //How many results are there in total? NOTE: item.Tracks = item.Artists = null
        }

        public static List<string> GetGenres(FullTrack track)
        {
            FullArtist fullArtist = Api.GetArtist(track.Artists.FirstOrDefault()?.Id);
            return fullArtist.Genres;
        }

        public static FullPlaylist NewPlaylist(string userId, string playlistName)
        {
            var playlist = Api.CreatePlaylist(userId, playlistName);
            return !playlist.HasError() ? playlist : null;
        }

        public static void SpotifyInit()
        {
            //  SpotifyAPI.Web.Auth.ImplictGrantAuth
            var auth =
                new ImplicitGrantAuth(ClientId, "http://localhost:8080", "http://localhost:8080",
                    Scope.PlaylistReadCollaborative);
            auth.AuthReceived += (_, payload) =>
            {
                auth.Stop(); // `sender` is also the auth instance
                Api = new SpotifyWebAPI { TokenType = payload.TokenType, AccessToken = payload.AccessToken };
                // Do requests with API client
                var profile = Api.GetPrivateProfile();
                UserId = profile.Id;
            };
            auth.Start(); // Starts an internal HTTP Server

            auth.OpenBrowser();
        }

        public static bool TrackDupe(string playlistId, string trackId)
        {
            var playlist = Api.GetPlaylistTracks(playlistId);
            return playlist.Items.Count > 0 && playlist.Items.Any(playlistTrack => playlistTrack.Track.Id.Equals(trackId));
        }

        public Task CreateTrackCardPanelAsync(PlaylistTrack track)
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

        private void BtnCreateAndSetPlaylists_Click(object sender, EventArgs e)
        {
            JsonHandler.SetMonthPlaylistId();
        }

        private async void Button1_Click(object sender, EventArgs e) => await PopulateTaskAsync().ConfigureAwait(false);

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
            SpotifyInit();
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            PopulatePlaylists();
        }

        private void PopulatePlaylists()
        {
            var playlists = Api.GetUserPlaylists(UserId, 50);
            if (playlists == null) return;
            foreach (var playlist in playlists.Items)
            {
                Label x = new Label
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

        private async Task PopulateTaskAsync()
        {
            TrackList = new List<FullTrack>();
            TackListPanel.Controls.Clear();
            var listOfTasks = new List<Task>();
            foreach (var songItem in _songItems)
            {
                foreach (var track in songItem.TrackList)
                {
                    Console.WriteLine(@"Full track name: " + track);
                    Console.WriteLine(@"Full Artist name: " + songItem.Artist);
                    var fullTrack =
                        await GetFullTrackAsync(track.Replace("(Ft.", "").Replace("(With ", "") + " " +
                                                songItem.Artist.Replace("&", ",").Replace("(Ft.", ""))
                            .ConfigureAwait(true);

                    try
                    {
                        listOfTasks.Add(CreateTrackCardPanelAsync(fullTrack));
                        var first = fullTrack.Album.Images.FirstOrDefault();

                        if (first != null) Console.WriteLine(first.Height + @" " + first.Width);
                        if (!TrackDupe(JsonHandler.GetMonthPlaylistId(songItem.ReleaseDate),
                            fullTrack.Uri))
                        {
                            TrackList.Add(fullTrack);
                            //Api.AddPlaylistTrack(jsonHandler.GetMonthPlaylistId(songItem.ReleaseDate),
                            //    fullTrack.Uri);
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(@"Error with track: " + track);
                        Console.WriteLine(exception);
                    }
                }
            }
            await Task.WhenAll(listOfTasks).ConfigureAwait(false);
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
            var playlist = await Api.GetPlaylistAsync(playlistId).ConfigureAwait(true);
            await DisplayPlaylistsSongsAsync(playlist).ConfigureAwait(false);
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
    }
}