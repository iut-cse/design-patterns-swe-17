using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScoreBoard
{
    class Cricket : Sport
    {
        public override void TeamInfo()
        {
            Console.WriteLine("Ravenclaw vs Slytherin\nT20\n");
        }

        public override void Scores()
        {
            Console.WriteLine("121/6 (16.1) - 122/7 (18.4)\n"); ;
        }

        public override void TopPlayers()
        {
            Console.WriteLine("Best Batter: Luna of Ravenclaw\nBest Bowler: Regulus of Slytherin"); ;
        }
    }
}
