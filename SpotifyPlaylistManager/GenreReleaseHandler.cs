using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CodeHollow.FeedReader;

namespace SpotifyPlaylistManager
{
    internal class GenreReleaseHandler
    {
        //This file currently get new releases from a specific genre(Hardstyle) and finds them on Spotify
        //Planning to make this more generic and have it find new releases for what ever genre you specify

        private const string HtmlTagPattern = "<.*?>";

        private const string Pattern = @"\((.*?)\)";

        private const string Re1 = "(\\d+)";

        // Integer Number 1
        private const string Re2 = "(.)";

        // Any Single Character 1
        private const string Re3 = "(\\s+)";

        private static readonly Regex R = new Regex(Re1 + Re2 + Re3, RegexOptions.IgnoreCase | RegexOptions.Singleline);

        private static List<SongItem> _songItems;

        private static string StripString(string inputString, string pattern)
        {
            var s = Regex.Replace
                (inputString, pattern, string.Empty);
            return Regex.Replace(s, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
        }

        public static async Task<List<SongItem>> Feed()
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

            return _songItems;
        }
    }
}