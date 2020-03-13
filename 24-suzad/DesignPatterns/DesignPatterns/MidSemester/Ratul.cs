﻿using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        ICloseAction closeAction;
        DistantAction disaction;

        public Ratul(ICloseAction closeAction, DistantAction disaction)
        {
            this.closeAction = closeAction;
            this.disaction = disaction;
        }
        public string ExecuteCloseAction()
        {
            return closeAction.execute();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return disaction.execute();
        }
    }
}
