using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Power : DistantAction
    {
        public override IEnumerable<string> ExecuteAction()
        {
            return SequenceOfActions();
        }
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

