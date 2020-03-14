using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Kick: ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "kick";
        }
    }
}
