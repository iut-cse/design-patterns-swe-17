
using DesignPatterns.__Commons;
using DesignPatterns.Template.Scoreboards;
using Xunit;

namespace DesignPatterns.Test._Demos
{
    public class ScoreboardDemo
    {
        private readonly OutputFile output;

        public ScoreboardDemo()
        {
            output = new OutputFile();
        }

        [Fact]
        void Demo()
        {
            output
                .Write(new CricketScoreboard().GetStats())
                .AppendLine()
                .AppendLine()
                .AppendLine()
                .Append(new FootballScoreboard().GetStats());
        }
    }
}
