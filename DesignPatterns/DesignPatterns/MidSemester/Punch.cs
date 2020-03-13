using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Punch : I_CloseAction
    {
        public string DoAction()
        {
            return "Punch!!!";
        }
    }
}
