using System;

namespace TaskScoreBoard
{
    class Scoreboard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the Sport:");
            string sportname = Console.ReadLine();

            Sport obj = null;

            if (sportname == "football")
            {
                obj = new Football();    
            }
            else if (sportname == "cricket")
            {
                obj = new Cricket(); 
            }

            obj.TeamInfo();
            Console.WriteLine("\n== == ==\n");
            obj.Scores();
            Console.WriteLine("\n== == ==\n");
            obj.TopPlayers();
        }
    }
}
