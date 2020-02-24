using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SpotifyPlaylistManager
{
    public static class JsonHandler
    {
        public static string GetMonthPlaylistId(MainForm.Months month)
        {
            var s = Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(s);
            using var file = File.OpenText(directory + @"\PlaylistMonths.json");
            var serializer = new JsonSerializer();
            var playlistMonthIds = (List<PlaylistMonthId>)serializer.Deserialize(file, typeof(List<PlaylistMonthId>));
            return playlistMonthIds[Convert.ToInt32(month)].PlaylistId;
        }

        public static void SetMonthPlaylistId()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(s);
            var playlistMonthIds = (from object month in Enum.GetValues(typeof(MainForm.Months)) let playlist = MainForm.NewPlaylist(MainForm.UserId, "Hardstyle " + month.ToString()) select new PlaylistMonthId { Month = Convert.ToInt32(month), PlaylistId = playlist.Id }).ToList();
            using var file = File.CreateText(directory + @"\PlaylistMonths.json");
            var serializer = new JsonSerializer();
            serializer.Serialize(file, playlistMonthIds);
        }
    }
}