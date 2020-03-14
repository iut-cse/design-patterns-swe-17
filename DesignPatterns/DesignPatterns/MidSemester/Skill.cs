using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Skill : DistantAction
    {
        public override string Grab()
        {
            return "Collar Dhore Uthao";
        }

        public override string Hit()
        {
            return "Pet a hatu diye maro";
        }
    }
}
