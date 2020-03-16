using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class CloseAction:Action
    {
        public abstract IEnumerable<string> ExecuteAction();
    }
}
