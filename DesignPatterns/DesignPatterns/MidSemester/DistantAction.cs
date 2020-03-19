using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public List<string> ActionList = new List<string>();

        public IEnumerable<string> ExecuteDistantAction()
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

    public class PowerDistantAction : DistantAction
    {
        public override string Grab()
        {
            return "pick up";
        }

        public override string Hit()
        {
            return "slam!";
        }
    }

    public class SkillDistantAction : DistantAction
    {
        public override string Grab()
        {
            return "hold collar";
        }

        public override string Hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}