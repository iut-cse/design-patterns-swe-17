using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Punch:CloseAction
    {
        public void performCloseAction()
        {
            Console.WriteLine("Punch");
        }
    }
}
