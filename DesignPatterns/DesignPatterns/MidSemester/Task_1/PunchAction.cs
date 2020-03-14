using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public class PunchAction : ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "punch";
        }
    }
}
