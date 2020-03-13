using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public List<string> ActionList = new List<string>();

        public IEnumerable<string> AllDistantAction()
        {
            ActionList.Add(Move());
            ActionList.Add(Grab());
            ActionList.Add(Hit());

            return ActionList;
        }

        public string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}