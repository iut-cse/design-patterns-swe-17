using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Skill_distantAction : distantAction
    {
        public override string Grab()
        {
            return "Hold collar!";
        }

        public override string Hit()
        {
            return "Hit knee!";
        }
    }
}
