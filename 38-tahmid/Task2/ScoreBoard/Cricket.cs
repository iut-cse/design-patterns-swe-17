using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreBoard
{
    class Cricket :ScoreBoard
    {
        String team1, team2, score, bestBatsman,bestBowler, gameType,interval = "== == ==";
       public Cricket(String team1, String team2, String score, String bestBatsman,String bestBowler,String gameType)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.score = score;
            this.bestBatsman = bestBatsman;
            this.bestBowler = bestBowler;
        }
        public void display()
        {
            System.Console.WriteLine(team1 + " vs " + team2);
            System.Console.WriteLine(interval);
            System.Console.WriteLine(score);
            System.Console.WriteLine(interval);
            System.Console.WriteLine("Best Batter:" + bestBatsman);
            System.Console.WriteLine("Best Bowler:" + bestBowler);


        }

        public void disPlay()
        {
            System.Console.WriteLine(team1 + " vs " + team2);
            System.Console.WriteLine(interval);
            System.Console.WriteLine(score);
            System.Console.WriteLine(interval);
            System.Console.WriteLine("Best Batter:" + bestBatsman);
            System.Console.WriteLine("Best Bowler:" + bestBowler);
        }
    }
}
