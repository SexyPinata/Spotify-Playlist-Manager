using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyPlaylistManager
{
    internal class SpotifyEasyApiHandler
    {
        public static SpotifyWebAPI Api = new SpotifyWebAPI();

        public static string UserId;

        private const string ClientId = "0b77d4294b49451bba2571fa3d09ae46";

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

        public static bool TrackDupe(string playlistId, string trackId)
        {
            var playlist = Api.GetPlaylistTracks(playlistId);
            return playlist.Items.Count > 0 && playlist.Items.Any(playlistTrack => playlistTrack.Track.Id.Equals(trackId));
        }

        public static Paging<SimplePlaylist> GetCurrentUsersPlaylists()
        {
            var playlists = Api.GetUserPlaylists(UserId, 50);
            return playlists;
        }
    }
}