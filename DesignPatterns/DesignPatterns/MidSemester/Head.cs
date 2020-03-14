using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Head:ICloseAction
    {
        public string performCloseAction()
        {
            return "Head";
        }
    }
}
