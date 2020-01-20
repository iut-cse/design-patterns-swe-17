using System;

namespace ScoreBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreBoard scoreBoard = new Football("Gryffindor", " Hufflepuff", "2 - 3", "Newt of Hufflepuff");
            scoreBoard.disPlay();
        }
    }
}
