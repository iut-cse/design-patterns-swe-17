using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_1
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
