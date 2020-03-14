using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Kick_hit : I_CloseAction
    {
        public string execute_hit()
        {
            return "kick";
        }
    }
}
