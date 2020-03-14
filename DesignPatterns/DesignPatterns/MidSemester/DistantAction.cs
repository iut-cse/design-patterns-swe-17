using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public IEnumerable<string> ExecuteDistantAction()
        {
            yield return move();
            yield return grab();
            yield return hit();
        }

        private string move()
        {
            return "move";
        }


        public abstract string grab();
        public abstract string hit();

    }
}
