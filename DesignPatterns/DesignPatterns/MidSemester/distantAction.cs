using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class distantAction
    {
        public List<string> actionList = new List<string>();

        public IEnumerable<string> AllDistantAction()
        {
            actionList.Add(Move());
            actionList.Add(Grab());
            actionList.Add(Hit());

            return actionList;
        }
        public string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}
