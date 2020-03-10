using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction : IDistantAction
    {
        public abstract string Grab();

        public abstract string Hit();

        public string Move()
        {
            return "move";
        }

        public IEnumerable<string> TakeDistantAction()
        {
            yield return this.Move();
            yield return this.Grab();
            yield return this.Hit();
        }
    }

    public class Power : DistantAction
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

    public class Skill : DistantAction
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
