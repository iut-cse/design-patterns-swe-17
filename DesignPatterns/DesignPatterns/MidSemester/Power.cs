using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Power: DistantAction
    {
        //"move", "pick up", "slam!"
        public override string grab()
        {
            return "pick up";
        }

        public override String hit()
        {
            return "slam!";
        }
    }
}
