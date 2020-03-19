using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class IDistantAction
    {
        internal IEnumerable<string> DistantAction()
        {
            yield return this.Move();
            yield return this.Grab();
            yield return this.Hit();
        }

        private string Move()
        {
            return "move";
        }

        internal abstract string Hit();
        internal abstract string Grab();

    }
}
