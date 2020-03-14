using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Head:CloseAction
    {
        public void performCloseAction()
        {
            Console.WriteLine("Head");
        }
    }
}
