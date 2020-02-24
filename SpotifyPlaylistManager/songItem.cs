using System.Collections.Generic;

namespace SpotifyPlaylistManager
{
    internal class SongItem
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public MainForm.Months ReleaseDate { get; set; }
        public List<string> TrackList { get; set; }

        public SongItem(string artist, string label, MainForm.Months releaseDate, List<string> trackList)
        {
            Artist = artist;
            Label = label;
            ReleaseDate = releaseDate;
            TrackList = trackList;
        }
    }
}