using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.task_1
{
    public class Power : DistantAction
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
