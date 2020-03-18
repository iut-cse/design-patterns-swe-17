﻿using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        public ICloseAction CurrentCloseAction;
        public DistantAction CurrentDistantAction;

         public Ratul(ICloseAction currentCloseAction,DistantAction currentDistantAction)
        {
            this.CurrentCloseAction = currentCloseAction;
            this.CurrentDistantAction = currentDistantAction;
        }

        public string ExecuteCloseAction()
        {
            return CurrentCloseAction.DoAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return CurrentDistantAction.AllDistantAction();
        }
    }
}
