using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public IEnumerable<string> ExecuteDistantAction()
        {
            yield return Move();
            yield return Grab();
            yield return Hit();
        }
        private String Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}
