using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public class Skill : DistantAction
    {
        protected override string Grab()
        {
            return "hold collar";
        }
        protected override string Hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
