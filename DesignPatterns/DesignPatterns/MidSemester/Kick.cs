using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem1
{
    public class Kick : ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "kick";
        }
    }
}