using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Punch_hit : I_CloseAction
    {
        public string execute_hit()
        {
            return "punch";
        }
    }
}
