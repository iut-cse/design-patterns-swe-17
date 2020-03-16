using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public interface Action
    {
        public IEnumerable<string> ExecuteAction();
    }
}
