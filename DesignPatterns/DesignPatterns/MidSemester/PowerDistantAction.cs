using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class PowerDistantAction : DistantAction
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
