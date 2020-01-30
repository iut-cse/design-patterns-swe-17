namespace DesignPatterns.Template.Scoreboards
{
    public class FootballScoreboard : Scoreboard
    {
        public override string GetBestScorer()
        {
            return "Player of the match: Cedric of Hufflepuff";
        }

        public override string GetGameInfo()
        {
            return "Gryffindor vs Hufflepuff";
        }

        public override string GetScore()
        {
            return "2 - 3";
        }
    }
}
