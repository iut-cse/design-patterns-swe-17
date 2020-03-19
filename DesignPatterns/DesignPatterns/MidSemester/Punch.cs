using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem1
{
    public class Punch : ICloseAction
    { 
        public string ExecuteCloseAction()
        {
            return "punch";
        }
    }
}