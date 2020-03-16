using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Head : CloseAction
    {

        public override IEnumerable<string> ExecuteAction()
        {
            return new List<string>() { "head head" };
        }
    }
}
