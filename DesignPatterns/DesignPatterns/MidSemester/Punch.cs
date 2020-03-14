using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Punch:ICloseAction
    {
        public string performCloseAction()
        {
            return "Punch";
        }
    }
}
