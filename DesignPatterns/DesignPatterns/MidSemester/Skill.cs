using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Skill:DistantAction
    {
        public override string Grab()
        {
            return "Hold Collar";
        }
        public override string Hit()
        {
            return "Knee";
        }
    }
}
