using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Head : ICloseAction
    {
        public string performCloseAction()
        {
            return "head head";
        }
    }
}
