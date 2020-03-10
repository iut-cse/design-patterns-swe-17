using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public IEnumerable<String> Performdistantaction()
        {
            yield return Move();
            yield return Grab();
            yield return Hit();
        }
        private String Move()
        {
            return "move";
        }
        abstract public String Grab();
        abstract public String Hit();
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
