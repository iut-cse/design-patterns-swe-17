using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class IDistantAction
    {
        public IEnumerable<string> ExecuteAction()
        {
            return move();
            return grab();
            return hit();
        }

        public string move()
        {
            return "move";
        }

        public abstract string grab();
        public abstract string hit();
    }
}