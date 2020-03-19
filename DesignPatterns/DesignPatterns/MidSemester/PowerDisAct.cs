using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class PowerDisAct : DistantAction
    {
       public override string Grab()
        {
            return "Pick Up";
        }
        public override string Hit()
        {
            return "Slam!";
        }
    }
}


