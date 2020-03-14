using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.task_1
{
    public class Punch : ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "punch";
        }
    }
}
