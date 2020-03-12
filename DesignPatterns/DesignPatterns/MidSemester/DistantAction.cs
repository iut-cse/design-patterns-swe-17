using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction :IDistantAction
    {
        public string Move()
        {
            return "move";
        }
        public abstract string Grab();
        public abstract string Hit();

        public IEnumerable<string> performDistantAction()
        {
            yield return Move();
            yield return Grab();
            yield return Hit();
        }

    }
}
