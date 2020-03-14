using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Power : DistantAction
    {
        public override string Grab()
        {
            return "Upore Uthao";
        }

        public override string Hit()
        {
            return "Matite Achar";
        }
    }
}
