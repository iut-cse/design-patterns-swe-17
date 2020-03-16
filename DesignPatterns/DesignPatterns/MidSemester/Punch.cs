using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Punch : CloseAction
    {

        public override IEnumerable<string> ExecuteAction()
        {
            return new List<string>() { "punch" };
        }
    }
}
