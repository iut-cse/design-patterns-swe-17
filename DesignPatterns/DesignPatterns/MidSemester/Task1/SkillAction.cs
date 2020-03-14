﻿using System.Collections.Generic;

namespace DesignPatterns.MidSemester
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