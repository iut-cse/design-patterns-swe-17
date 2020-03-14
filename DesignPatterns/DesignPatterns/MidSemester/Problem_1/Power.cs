using System;

namespace DesignPatterns.MidSemester.Problem_1
{
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
}
