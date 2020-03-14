using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public class HeadAction : ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "head head";
        }
    }
}
