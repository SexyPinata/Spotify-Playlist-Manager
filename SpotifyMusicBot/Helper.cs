namespace SpotifyMusicBot
{
    public static class Helper
    {
        public static Form1.Months GetMonth(string releaseDate)
        {
            if (releaseDate.Contains(Form1.Months.January.ToString()))
            {
                return Form1.Months.January;
            }
            if (releaseDate.Contains(Form1.Months.February.ToString()))
            {
                return Form1.Months.February;
            }
            if (releaseDate.Contains(Form1.Months.Mars.ToString()))
            {
                return Form1.Months.Mars;
            }
            if (releaseDate.Contains(Form1.Months.April.ToString()))
            {
                return Form1.Months.April;
            }
            if (releaseDate.Contains(Form1.Months.May.ToString()))
            {
                return Form1.Months.May;
            }
            if (releaseDate.Contains(Form1.Months.June.ToString()))
            {
                return Form1.Months.June;
            }
            if (releaseDate.Contains(Form1.Months.July.ToString()))
            {
                return Form1.Months.July;
            }
            if (releaseDate.Contains(Form1.Months.August.ToString()))
            {
                return Form1.Months.August;
            }
            if (releaseDate.Contains(Form1.Months.September.ToString()))
            {
                return Form1.Months.September;
            }
            if (releaseDate.Contains(Form1.Months.October.ToString()))
            {
                return Form1.Months.October;
            }
            if (releaseDate.Contains(Form1.Months.November.ToString()))
            {
                return Form1.Months.November;
            }
            if (releaseDate.Contains(Form1.Months.December.ToString()))
            {
                return Form1.Months.December;
            }

            return Form1.Months.None;
        }
    }
}