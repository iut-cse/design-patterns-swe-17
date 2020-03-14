using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Kick:ICloseAction
    {
        public string performCloseAction()
        {
            return "Kick";
        }
    }
}
