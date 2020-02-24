using System.Collections.Generic;

namespace SpotifyMusicBot
{
    internal class songItem
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public Form1.Months ReleaseDate { get; set; }
        public List<string> TrackList { get; set; }

        public songItem(string artist, string label, Form1.Months releaseDate, List<string> trackList)
        {
            Artist = artist;
            Label = label;
            ReleaseDate = releaseDate;
            TrackList = trackList;
        }
    }
}