using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction:IDistantAction
    {
        public string move()
        {
            return "move";
        }
        public abstract string grab();
        public abstract string hit();
        public IEnumerable<string> performDistantAction()
        {
            yield return move();
            yield return grab();
            yield return hit();
        }
    }
}
