using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem1
{
    public class Power : DistantAction
    {
        public override string Grab()
        {
            return "pick up";
        }
        public override string Hit(){
            return "slam!";
        }
    }
}