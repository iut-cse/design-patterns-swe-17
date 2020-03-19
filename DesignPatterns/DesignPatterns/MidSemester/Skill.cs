using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Skill : IDistantAction
    {
        internal override string Grab()
        {
            return "hold collar";
        }

        internal override string Hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
