using CodeHollow.FeedReader;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyPlaylistManager
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public static SpotifyWebAPI Api = new SpotifyWebAPI();

        public static string UserId = null;

        private const string ClientId = "0b77d4294b49451bba2571fa3d09ae46";

        private const string HtmlTagPattern = "<.*?>";

        private const string Pattern = @"\((.*?)\)";

        private const string Re1 = "(\\d+)";

        // Integer Number 1
        private const string Re2 = "(.)";

        // Any Single Character 1
        private const string Re3 = "(\\s+)";

        private static readonly Regex R = new Regex(Re1 + Re2 + Re3, RegexOptions.IgnoreCase | RegexOptions.Singleline);

        private static List<SongItem> _songItems;

        // White Space 1
        private List<FullTrack> _trackList = new List<FullTrack>();

        public MainForm()
        {
            InitializeComponent();
        }

        public enum Months { None, January, February, Mars, April, May, June, July, August, September, October, November, December };

        public static async void Feed()
        {
            var feed = await FeedReader.ReadAsync("https://www.hardstyle-releases.com/feed/").ConfigureAwait(false);
            _songItems = new List<SongItem>();
            // ...
            foreach (var item in feed.Items)
            {
                var str = StripString(item.Content, HtmlTagPattern)
                    .Replace("The post " + item.Title + " appeared first on Hardstyle-Releases.com.",
                        "");
                var result = Regex.Split(str, "\r\n|\r|\n").ToList();
                if (result.Count > 4)
                {
                    var list = result.Skip(2).Select(variable => Regex.Replace(variable, Re1 + Re2 + Re3, "")).ToList();
                    SongItem trackItem = new SongItem(StripString(item.Title, Pattern), result[0].Replace("Label: ", ""), Helper.GetMonth(result[1].Replace("Release Date: ", "")), list);

                    _songItems.Add(trackItem);
                }
                if (result.Count < 4)
                {
                    var x = item.Title.Split('–');
                    var list = new List<string> {Regex.Replace(x[1], Re1 + Re2 + Re3, "")
                    };
                    SongItem trackItem = new SongItem(StripString(x[0], Pattern), result[0].Replace("Label: ", ""), Helper.GetMonth(result[1].Replace("Release Date: ", "")), list);
                    _songItems.Add(trackItem);
                }
                else
                {
                    var list = new List<string> {Regex.Replace(result[2], Re1 + Re2 + Re3, "")
                    };
                    SongItem trackItem = new SongItem(StripString(item.Title, Pattern), result[0].Replace("Label: ", ""), Helper.GetMonth(result[1].Replace("Release Date: ", "")), list);
                    _songItems.Add(trackItem);
                }

                //                Console.WriteLine(StripString(item.Title, PATTERN) + ":\n" + StripString(item.Content, HTML_TAG_PATTERN)
                //                                      .Replace("The post " + item.Title + " appeared first on Hardstyle-Releases.com.",
                //                                          ""));
            }
        }

        public static async Task<FullTrack> GetFullTrack(string searchTerm)
        {
            SearchItem item = await Api.SearchItemsAsync(searchTerm.Replace("#", ""), SearchType.All).ConfigureAwait(false);
            Console.WriteLine("Searched for: " + searchTerm);
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

        public Task CreateTrackCardPanel(PlaylistTrack track)
        {
            var trackCard = new TrackCard(track.Track);
            trackCard.AlbumImage.LoadAsync(track.Track.Album.Images.FirstOrDefault()?.Url);
            trackCard.TrackName.Text = track.Track.Name;

            TackListPanel.Controls.Add(trackCard);
            return Task.CompletedTask;
        }

        public Task CreateTrackCardPanel(FullTrack track)
        {
            var trackCard = new TrackCard(track);
            trackCard.AlbumImage.LoadAsync(track.Album.Images.FirstOrDefault()?.Url);
            trackCard.TrackName.Text = track.Name;

            TackListPanel.Controls.Add(trackCard);
            return Task.CompletedTask;
        }

        private static string StripString(string inputString, string pattern)
        {
            var s = Regex.Replace
                (inputString, pattern, string.Empty);
            return Regex.Replace(s, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
        }

        private void BtnCreateAndSetPlaylists_Click(object sender, EventArgs e)
        {
            JsonHandler.SetMonthPlaylistId();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            await PopulateTask().ConfigureAwait(false);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private async Task DisplayPlaylistsSongs(FullPlaylist playlist)
        {
            TackListPanel.Controls.Clear();
            List<Task> listOfTasks = new List<Task>();

            foreach (var track in playlist.Tracks.Items)
                listOfTasks.Add(CreateTrackCardPanel(track));
            await Task.WhenAll(listOfTasks).ConfigureAwait(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Feed();
            SpotifyInit();
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            PopulatePlaylists();
        }

        private void PlaylistPanel_Click(object sender, EventArgs e)
        {
        }

        private void PopulatePlaylists()
        {
            var playlists = Api.GetUserPlaylists(UserId, 50, 0);
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

        private async Task PopulateTask()
        {
            _trackList = new List<FullTrack>();
            TackListPanel.Controls.Clear();
            List<Task> listOfTasks = new List<Task>();
            foreach (var songItem in _songItems)
            {
                foreach (var track in songItem.TrackList)
                {
                    Console.WriteLine("Full track name: " + track);
                    Console.WriteLine("Full Artist name: " + songItem.Artist);
                    var fullTrack = await GetFullTrack(track.Replace("(Ft.", "").Replace("(With ", "") + " " + songItem.Artist.Replace("&", ",").Replace("(Ft.", "")).ConfigureAwait(true);

                    try
                    {
                        listOfTasks.Add(CreateTrackCardPanel(fullTrack));
                        var first = fullTrack.Album.Images.FirstOrDefault();

                        if (first != null) Console.WriteLine(first.Height + " " + first.Width);
                        if (!TrackDupe(JsonHandler.GetMonthPlaylistId(songItem.ReleaseDate),
                            fullTrack.Uri))
                        {
                            _trackList.Add(fullTrack);
                            //Api.AddPlaylistTrack(jsonHandler.GetMonthPlaylistId(songItem.ReleaseDate),
                            //    fullTrack.Uri);
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Error with track: " + track);
                        Console.WriteLine(exception);
                    }
                }
            }
            await Task.WhenAll(listOfTasks).ConfigureAwait(false);
        }

        private void RadPopupEditor1_Click(object sender, EventArgs e)
        {
        }

        private void Tes2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private async void X_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label plSender = sender as Label;
            var playlistId = plSender.Name;
            var playlist = await Api.GetPlaylistAsync(playlistId);
            await DisplayPlaylistsSongs(playlist).ConfigureAwait(false);
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.LightGray;
        }

        private void XOnMouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.GhostWhite;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FullTrack m = new FullTrack();
            CreateTrackCardPanel(m);
        }
    }
}