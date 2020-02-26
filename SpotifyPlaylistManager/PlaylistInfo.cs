using System;
using System.Threading.Tasks;
using SpotifyAPI.Web.Models;
using Telerik.WinControls.UI;

namespace SpotifyPlaylistManager
{
    public struct PlaylistInfo
    {
        #region Fields

        public float Acousticness, Danceability, Energy, Instrumentalness, Loudness, Valence, Tempo;
        public FullPlaylist Playlist;
        public PlaylistPopularityBalance PlaylistPopularityBalance;

        public PlaylistInfo(float acousticness, float danceability, float energy, float instrumentalness, float loudness, float valence, float tempo, PlaylistPopularityBalance playlistPopularityBalance, FullPlaylist playlist)
        {
            Acousticness = acousticness;
            Danceability = danceability;
            Energy = energy;
            Instrumentalness = instrumentalness;
            Loudness = loudness;
            Valence = valence;
            Tempo = tempo;
            PlaylistPopularityBalance = playlistPopularityBalance;
            Playlist = playlist;
        }

        #endregion Fields
    }

    public struct PlaylistPopularityBalance
    {
        #region Fields

        public int LowPop, MedPop, HighPop;

        #endregion Fields

        #region Constructors

        public PlaylistPopularityBalance(int low, int med, int high)
        {
            LowPop = low;
            MedPop = med;
            HighPop = high;
        }

        #endregion Constructors
    }

    public class PlaylistInfoHelper
    {
        #region Enums

        public enum AudioFeature
        {
            Acousticness, Danceability, Energy, Instrumentalness, Loudness, Valence, Tempo
        }

        #endregion Enums

        #region Methods

        public static async Task<float> GetAverageAsync(FullPlaylist playlist, AudioFeature feature)
        {
            var total = 0f;
            foreach (var playlistTrack in playlist.Tracks.Items)
            {
                var audioFeatures = await SpotifyEasyApiHandler.Api.GetAudioFeaturesAsync(playlistTrack.Track.Id).ConfigureAwait(false);
                total += feature switch
                {
                    AudioFeature.Acousticness => (int)Math.Round(audioFeatures.Acousticness * 100),
                    AudioFeature.Danceability => (int)Math.Round(audioFeatures.Danceability * 100),
                    AudioFeature.Energy => (int)Math.Round(audioFeatures.Energy * 100),
                    AudioFeature.Instrumentalness => (int)Math.Round(audioFeatures.Instrumentalness * 100),
                    AudioFeature.Loudness => (int)Math.Round(audioFeatures.Loudness),
                    AudioFeature.Valence => (int)Math.Round(audioFeatures.Valence * 100),
                    AudioFeature.Tempo => (int)Math.Round(audioFeatures.Tempo),
                    _ => throw new ArgumentOutOfRangeException(nameof(feature), feature, null)
                };
            }
            Console.WriteLine("Average: " + total / playlist.Tracks.Items.Count + " of type: " + feature);
            return total / playlist.Tracks.Items.Count;
        }

        #endregion Methods
    }
}