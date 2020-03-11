using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        internal IEnumerable<string> executeaction()
        {
            yield return this.move();
            yield return this.grab();
            yield return this.hit();
        }
        string move()
        {
            return "move";
        }
        public abstract string grab();
        public abstract string hit();
    }

}
