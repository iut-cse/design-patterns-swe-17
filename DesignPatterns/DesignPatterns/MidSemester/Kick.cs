using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Kick:CloseAction
    {
        public void performCloseAction()
        {
            Console.WriteLine("Kick");
        }
    }
}
