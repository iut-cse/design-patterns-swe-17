using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class IDistantAction
    {
        public IEnumerable<string> TemplateMethod()
        {
            yield return this.move();
            yield return this.grab();
            yield return this.hit();

        }
        string move()
        {
            return "move";
        }

        public abstract string grab();
        public abstract string hit();
    }

    public class Power : IDistantAction
    {
        public override string grab()
        {
            return "pick up";
        }

        public override string hit()
        {
            return "slam";
        }
    }

    public class Skill : IDistantAction
    {
        public override string grab()
        {
            return "hold collar";
        }

        public override string hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
