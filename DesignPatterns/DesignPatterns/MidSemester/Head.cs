using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Head : ICloseAction
    {
        public string DoAction()
        {
            return "HEAD HEAD";
        }
    }
}
