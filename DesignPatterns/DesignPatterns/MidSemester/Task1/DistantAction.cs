using System.Collections.Generic;
using System;
using System.Text;

namespace DesignPatterns.MidSemester.Task1
{
    public abstract class DistantAction
    {

        public List<string> DistantActionList = new List<string>();

        public IEnumerable<string> AllDistantAction()
        {
            DistantActionList.Add(Move());
            DistantActionList.Add(Grab());
            DistantActionList.Add(Hit());

            return DistantActionList;
        }

        public string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}