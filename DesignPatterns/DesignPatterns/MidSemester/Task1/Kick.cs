using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Kick : ICloseAction
    {
        public string execute()
        {
            return "kick";
        }
    }
}