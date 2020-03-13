using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        CloseAction closeAction;
        DistantAction distantAction;
        private Power power;
        private Punch punch;

        public Ratul(CloseAction closeAction, DistantAction distantAction)
        {
            this.distantAction = distantAction;
            this.closeAction = closeAction;    
        }

      
        public string ExecuteCloseAction()
        {
            return closeAction.ExecuteAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.ExecuteAction();
        }
    }
}

