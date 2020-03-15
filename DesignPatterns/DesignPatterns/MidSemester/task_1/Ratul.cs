using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
    public class Ratul
    {

        private ICloseAction icloseAction;
        private DistantAction distantAction;


        public Ratul(ICloseAction icloseAction, DistantAction distantAction)
        {
            this.icloseAction = icloseAction;
            this.distantAction = distantAction;
        }
        public string ExecuteCloseAction()
        {
            return icloseAction.ExecuteCloseAction();
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
