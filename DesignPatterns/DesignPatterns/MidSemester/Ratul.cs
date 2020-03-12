using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        CloseAction closeAction;
        DistantAction distantAction;

        public Ratul(CloseAction closeAction) => this.closeAction = closeAction;
        public Ratul(DistantAction distantAction) => this.distantAction = distantAction;

        public string ExecuteCloseAction()
        {
            return closeAction.action();
        }



        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.executeaction();
        }
    }
}
