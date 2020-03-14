using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Punch : ICloseAction
    {
        public string execute()
        {
            return "punch";
        }
    }
}