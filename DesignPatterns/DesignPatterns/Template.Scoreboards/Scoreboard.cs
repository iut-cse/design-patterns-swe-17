namespace DesignPatterns.Template.Scoreboards
{
    public abstract class Scoreboard
    {
        public string GetStats()
        {
            var stats = GetGameInfo() + "\n";
            stats += "== == ==\n";
            stats += GetScore() + "\n";
            stats += "== == ==\n";
            stats += GetBestScorer();
            return stats;
        }

        public abstract string GetBestScorer();
        public abstract string GetScore();
        public abstract string GetGameInfo();
    }
}
