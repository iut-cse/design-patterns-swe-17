using System.Collections.Generic;
using System;
using System.Text;
namespace DesignPatterns.MidSemester.Task1
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

