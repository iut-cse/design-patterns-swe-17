using System;

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