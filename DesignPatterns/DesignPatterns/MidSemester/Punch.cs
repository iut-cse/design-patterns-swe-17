using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Punch:CloseAction
    {
        public string ExecuteCloseAction()
        {
            return "punch";
        }
    }
}
