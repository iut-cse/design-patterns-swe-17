using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Power:DistantAction
    {
        public override string Grab()
        {
            return "Pick up";
        }
        public override string Hit()
        {
            return "Slam";
        }
    }
}
