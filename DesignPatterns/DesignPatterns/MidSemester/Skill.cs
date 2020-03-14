using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Skill : DistantAction
    {
        public override string grab()
        {
            return "hold collar";
        }

        public override string hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
