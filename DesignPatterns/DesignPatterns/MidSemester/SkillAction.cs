using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class SkillAction : DistantAction
    {
        public override string Grab()
        {
            return "Hold Collar";
        }
        public override string Hit()
        {
            return "Hit with Knee";
        }
    }
}


