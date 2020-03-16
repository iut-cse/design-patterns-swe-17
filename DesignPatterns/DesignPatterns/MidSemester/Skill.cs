﻿using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Skill : DistantAction
    {
        public override IEnumerable<string> ExecuteAction()
        {
            return SequenceOfActions();
        }
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
