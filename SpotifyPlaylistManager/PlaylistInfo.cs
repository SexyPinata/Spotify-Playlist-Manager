using SpotifyAPI.Web.Models;

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
}