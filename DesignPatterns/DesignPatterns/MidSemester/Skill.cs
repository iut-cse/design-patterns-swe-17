using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Skill : DistantAction
    {
        public string grab()
        {
            return "hold collar";
        }
        public string hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
