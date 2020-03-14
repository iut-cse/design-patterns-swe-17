using System.Collections.Generic;
using System;
using System.Text;

namespace DesignPatterns.MidSemester.Task1
{
    public class Kick : ICloseAction
    {
        public string execute()
        {
            return "kick";
        }
    }
}