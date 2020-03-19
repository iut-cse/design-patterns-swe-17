using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem1
{
    public class Head : ICloseAction
    {
        public string ExecuteCloseAction()
        {
            return "head head";
        }
    }
}