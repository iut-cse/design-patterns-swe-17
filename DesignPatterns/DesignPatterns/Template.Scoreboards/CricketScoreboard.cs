namespace DesignPatterns.Template.Scoreboards
{
    public class CricketScoreboard : Scoreboard
    {
        protected override string GetBestScorer()
        {
            return "Best Batter: Luna of Ravenclaw";
        }

        protected override string GetGameInfo()
        {
            return "Ravenclaw vs Slytherin\nT20";
        }

        protected override string GetScore()
        {
            return "121/6 (16.1) - 122/7 (18.4)";
        }
    }
}
