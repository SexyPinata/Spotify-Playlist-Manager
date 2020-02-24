namespace SpotifyPlaylistManager
{
    public static class Helper
    {
        public static MainForm.Months GetMonth(string releaseDate)
        {
            if (releaseDate.Contains(nameof(MainForm.Months.January)))
            {
                return MainForm.Months.January;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.February)))
            {
                return MainForm.Months.February;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.Mars)))
            {
                return MainForm.Months.Mars;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.April)))
            {
                return MainForm.Months.April;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.May)))
            {
                return MainForm.Months.May;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.June)))
            {
                return MainForm.Months.June;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.July)))
            {
                return MainForm.Months.July;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.August)))
            {
                return MainForm.Months.August;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.September)))
            {
                return MainForm.Months.September;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.October)))
            {
                return MainForm.Months.October;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.November)))
            {
                return MainForm.Months.November;
            }
            if (releaseDate.Contains(nameof(MainForm.Months.December)))
            {
                return MainForm.Months.December;
            }

            return MainForm.Months.None;
        }
    }
}