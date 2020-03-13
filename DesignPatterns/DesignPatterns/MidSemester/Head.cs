using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Head : I_CloseAction
    {
        public string DoAction()
        {
            return "Head!!!";
        }
    }
}
