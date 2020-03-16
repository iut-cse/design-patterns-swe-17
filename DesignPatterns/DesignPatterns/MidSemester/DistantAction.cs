using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction : Action
    {
        public abstract IEnumerable<string> ExecuteAction();
        public IEnumerable<string> SequenceOfActions()
        {
            return new List<string>() { Move(),Grab(),Hit() };
        }
        public string Move()
        {
            return "move";
        }
        public abstract string Grab();
        public abstract string Hit();
    }
}
