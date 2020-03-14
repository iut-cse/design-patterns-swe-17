using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public abstract string grab();

        public abstract string hit();

        public string move()
        {
            return "move";
        }

        public IEnumerable<string> act()
        {
           yield return move();
           yield return grab();
           yield return hit();
           
        }
    }
}
