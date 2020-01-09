using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScoreBoard
{
    class Football : Sport
    { 
        public override void TeamInfo()
        {
            Console.WriteLine("Ravenclaw vs Slytherin\nT20\n");
        }

        public override void Scores()
        {
            Console.WriteLine("2 - 3\n");
        }

       
        public override void TopPlayers()
        {
            Console.WriteLine("Player of the match: Newt of Hufflepuff\n");
        }
    }
}
