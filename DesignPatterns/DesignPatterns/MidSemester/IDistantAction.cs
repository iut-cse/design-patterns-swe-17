using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface IDistantAction
    {
        public IEnumerable<string> performDistantAction();
    }
}
