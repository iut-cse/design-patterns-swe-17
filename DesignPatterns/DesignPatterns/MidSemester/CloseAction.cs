using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{

    public interface ICloseAction
    {
        String performCloseAction();
    }


    public class Punch : ICloseAction
    {
        public string performCloseAction()
        {
            return "punch";
        }
    }

    public class Kick : ICloseAction
    {
        public string performCloseAction()
        {
            return "kick";
        }
    }

    public class Head : ICloseAction
    {
        public string performCloseAction()
        {
            return "head head";
        }
    }

}