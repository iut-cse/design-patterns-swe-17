namespace DesignPatterns.Template.Scoreboards
{
    public class CricketScoreboard : Scoreboard
    {
        public override string GetBestScorer()
        {
            return "Best Batter: Luna of Ravenclaw\nBest Bowler: Regulus of Slytherin";
        }

        public override string GetGameInfo()
        {
            return "Ravenclaw vs Slytherin\nT20";
        }

        public override string GetScore()
        {
            return "121/6 (16.1) - 122/7 (18.4)";
        }
    }
}
