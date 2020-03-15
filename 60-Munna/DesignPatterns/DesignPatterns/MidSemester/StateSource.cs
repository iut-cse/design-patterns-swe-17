using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class StateSource : IStateSource
    {
        public string Stat(string state)
        {
            return state;
        }
    }
}
