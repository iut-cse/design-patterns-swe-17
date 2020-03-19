using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Power : IDistantAction
    {
        internal override string Grab()
        {
            return "pick up";
        }

        internal override string Hit()
        {
            return "slam!";
        }
    }
}
