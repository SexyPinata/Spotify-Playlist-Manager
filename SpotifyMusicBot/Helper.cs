namespace SpotifyMusicBot
{
    public static class Helper
    {
        public static Form1.Months GetMonth(string releaseDate)
        {
            if (releaseDate.Contains(nameof(Form1.Months.January)))
            {
                return Form1.Months.January;
            }
            if (releaseDate.Contains(nameof(Form1.Months.February)))
            {
                return Form1.Months.February;
            }
            if (releaseDate.Contains(nameof(Form1.Months.Mars)))
            {
                return Form1.Months.Mars;
            }
            if (releaseDate.Contains(nameof(Form1.Months.April)))
            {
                return Form1.Months.April;
            }
            if (releaseDate.Contains(nameof(Form1.Months.May)))
            {
                return Form1.Months.May;
            }
            if (releaseDate.Contains(nameof(Form1.Months.June)))
            {
                return Form1.Months.June;
            }
            if (releaseDate.Contains(nameof(Form1.Months.July)))
            {
                return Form1.Months.July;
            }
            if (releaseDate.Contains(nameof(Form1.Months.August)))
            {
                return Form1.Months.August;
            }
            if (releaseDate.Contains(nameof(Form1.Months.September)))
            {
                return Form1.Months.September;
            }
            if (releaseDate.Contains(nameof(Form1.Months.October)))
            {
                return Form1.Months.October;
            }
            if (releaseDate.Contains(nameof(Form1.Months.November)))
            {
                return Form1.Months.November;
            }
            if (releaseDate.Contains(nameof(Form1.Months.December)))
            {
                return Form1.Months.December;
            }

            return Form1.Months.None;
        }
    }
}