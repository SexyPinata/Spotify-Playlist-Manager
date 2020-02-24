using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SpotifyMusicBot
{
    public class jsonHandler
    {
        public static string GetMonthPlaylistId(Form1.Months month)
        {
            List<PlaylistMonthId> playlistMonthIds = new List<PlaylistMonthId>();
            var s = Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(s);
            using (var file = File.OpenText(directory + @"\PlaylistMonths.json"))
            {
                var serializer = new JsonSerializer();
                playlistMonthIds = (List<PlaylistMonthId>)serializer.Deserialize(file, typeof(List<PlaylistMonthId>));
            }
            return playlistMonthIds[Convert.ToInt32(month)].PlaylistId;
        }

        public static void SetMonthPlaylistId()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(s);
            var playlistMonthIds = (from object month in Enum.GetValues(typeof(Form1.Months)) let playlist = Form1.NewPlaylist(Form1.UserId, "Hardstyle " + month.ToString()) select new PlaylistMonthId { Month = Convert.ToInt32(month), PlaylistId = playlist.Id }).ToList();
            using (var file = File.CreateText(directory + @"\PlaylistMonths.json"))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, playlistMonthIds);
            }
        }
    }
}