using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    abstract class DistantAction
    {
        public IEnumerable<string>
        ExecuteDistantAction()
        {
            yield return Move();
            yield return Grab();
            yield return Hit();
        }

        private string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}
