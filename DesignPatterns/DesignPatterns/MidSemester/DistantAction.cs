using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    internal class DistantAction
    {
        internal IEnumerable<string> ExecuteAction()
        {
            move();
            grab();
            hit();

        }

        private string hit()
        {
            return "hit";
        }

        private string grab()
        {
            return "grab";
        }

        private string move()
        {
            return "move";
        }
    }
}