namespace DesignPatterns.Template.Scoreboards
{
    public abstract class Scoreboard
    {
        public string GetStats()
        {
            var stats = "";
            stats += GetBestScorer();
            stats += "== == ==\n";
            stats += GetScore() + "\n";
            stats += "== == ==\n";
            stats += GetGameInfo() + "\n";
            
            return stats;
        }

        protected abstract string GetBestScorer();
        protected abstract string GetScore();
        protected abstract string GetGameInfo();
    }
}
