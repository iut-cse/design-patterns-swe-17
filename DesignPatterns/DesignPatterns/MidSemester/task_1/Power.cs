using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public class Power : DistantAction
    {
        protected override string Grab()
        {
            return "pick up";
        }
        protected override string Hit()
        {
            return "slam!";
        }
    }
}
