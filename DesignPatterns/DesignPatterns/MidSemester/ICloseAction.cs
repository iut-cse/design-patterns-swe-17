using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface ICloseAction
    {
        public string TakeCloseAction();
    }

    public class Punch : ICloseAction
    {
        public string TakeCloseAction()
        {
            return "punch";
        }
    }

    public class Kick : ICloseAction
    {
        public string TakeCloseAction()
        {
            return "kick";
        }
    }

    public class Head : ICloseAction
    {
        public string TakeCloseAction()
        {
            return "head";
        }
    }
}