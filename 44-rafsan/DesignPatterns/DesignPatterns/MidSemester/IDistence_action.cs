using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class IDistant_action
    {
        public IEnumerable<string> Template_method()
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

    public class Power : IDistant_action
    {
        public override string grab()
        {
            return "pickUp_enemy";
        }

        public override string hit()
        {
            return "slam_enemy";
        }
    }

    public class Skill : IDistant_action
    {
        public override string grab()
        {
            return "hold collar";
        }

        public override string hit()
        {
            return "knee_enemy";
        }
    }
}

