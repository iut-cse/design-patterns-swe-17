using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class Distant_action
    {
        public List<string> distant_template()
        {
            List<string> list = new List<string>();
            list.Add(move());
            list.Add(grab());
            list.Add(hit());
            
            return list;
        }
        public string move()
        {
            return "move";
        }
        public abstract string grab();
        public abstract string hit();

    }
}
