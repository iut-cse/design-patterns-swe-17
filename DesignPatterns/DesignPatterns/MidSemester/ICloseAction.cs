using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface ICloseAction
    {
        public string DoAction();
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