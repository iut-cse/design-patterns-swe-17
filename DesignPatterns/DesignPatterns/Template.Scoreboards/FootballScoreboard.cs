namespace DesignPatterns.Template.Scoreboards
{
    public class FootballScoreboard : Scoreboard
    {
        protected override string GetBestScorer()
        {
            return "Player of the match: Cedric of Hufflepuff";
        }

        protected override string GetGameInfo()
        {
            return "Gryffindor vs Hufflepuff";
        }

        protected override string GetScore()
        {
            return "2 - 3";
        }
    }
}
