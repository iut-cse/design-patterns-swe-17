using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Kick : CloseAction
    {

        public override IEnumerable<string> ExecuteAction()
        {
            return new List<string>() { "kick" };
        }
    }
}
