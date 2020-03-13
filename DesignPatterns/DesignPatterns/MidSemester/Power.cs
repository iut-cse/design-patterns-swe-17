using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Power : DistantAction
    {
        public string grab()
        {
            return "pick up";
        }
        public string hit()
        {
            return "slam!";
        }
    }
}
