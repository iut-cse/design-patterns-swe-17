using System.Collections.Generic;
using System;
using System.Text;
namespace DesignPatterns.MidSemester.Task1
{
    public class SkillAction : DistantAction
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