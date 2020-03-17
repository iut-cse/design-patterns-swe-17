﻿using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Task1
{
    public class Ratul
    {   
        private ICloseAction closeAction;
        private DistantAction distantAction;

        public Ratul(ICloseAction closeAction, DistantAction distantAction){
            this.closeAction = closeAction;
            this. distantAction = distantAction;
        }
        public string ExecuteCloseAction()
        {
            return closeAction.ExecuteCloseAction;
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.ExecuteDistantAction();
        }
    }
}