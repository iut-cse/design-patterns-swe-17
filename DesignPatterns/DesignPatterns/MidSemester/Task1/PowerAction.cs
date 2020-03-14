using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class PowerAction : DistantAction
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

