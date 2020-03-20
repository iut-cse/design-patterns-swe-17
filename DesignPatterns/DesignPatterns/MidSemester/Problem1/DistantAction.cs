using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction : IDistantAction
    {
        public IEnumerable<string> Execute()
        {
            yield return Move();
            yield return Grab();
            yield return Hit();
        }

        private string Move()
        {
            return "move";
        }

        protected abstract string Grab();

        protected abstract string Hit();
    }
}
