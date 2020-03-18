using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{

    public interface ICloseAction
    {
        String action();
    }


    public class punch : ICloseAction
    {
        public string action()
        {
            return "punch";
        }
    }

    public class kick : ICloseAction
    {
        public string action()
        {
            return "kick";
        }
    }

    public class head : ICloseAction
    {
        public string action()
        {
            return "head head";
        }
    }

}