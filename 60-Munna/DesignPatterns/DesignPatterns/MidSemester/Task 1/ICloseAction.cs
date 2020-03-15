using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public interface ICloseAction
    {
        public string DoCloseAction();
    }

    public class Punch : ICloseAction
    {
        public string DoCloseAction()
        {
            return "punch";
        }
    }

    public class Kick : ICloseAction
    {
        public string DoCloseAction()
        {
            return "kick";
        }
    }
    public class Head : ICloseAction
    {
        public string DoCloseAction()
        {
            return "head head";
        }
    }
}
