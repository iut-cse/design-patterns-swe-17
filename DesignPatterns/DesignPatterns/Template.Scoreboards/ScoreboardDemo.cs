
using DesignPatterns.__Commons;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatterns.Template.Scoreboards
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
