using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public IEnumerable<string> ExecuteAction()
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