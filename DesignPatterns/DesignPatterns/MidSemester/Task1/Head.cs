using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Head : ICloseAction
    {
        public string execute()
        {
            return "head head";
        }
    }
}