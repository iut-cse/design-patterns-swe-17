using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreBoard
{
    class Football :ScoreBoard
    {
        String team1, team2, score, topPlayer,interval= "== == ==";
       public Football(String team1,String team2,String score,String topPlayer)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.score = score;
            this.topPlayer = topPlayer;
        }
       
        public void disPlay()
        {
            System.Console.WriteLine(team1 + " vs " + team2);
            System.Console.WriteLine(interval);
            System.Console.WriteLine(score);
            System.Console.WriteLine(interval);
            System.Console.WriteLine("Player of the match" + topPlayer);
        }
    }
}
