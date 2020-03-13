using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Kick : I_CloseAction
    {
        public string DoAction()
        {
            return "Kick!!!";
        }
    }
}
