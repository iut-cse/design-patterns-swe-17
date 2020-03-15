using System;

namespace DesignPatterns.MidSemester.Problem_1
{
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
