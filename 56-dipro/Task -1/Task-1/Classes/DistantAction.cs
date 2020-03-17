using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction : IDistantAction
    {
        public IEnumerable<string> Execute()
        {
            return new[] { Move(), Grab(), Hit() };
        }

        private string Move()
        {
            return "move";
        }

        protected abstract string Grab();
        protected abstract string Hit();


    }

}