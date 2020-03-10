using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        ICloseAction closeAction;
        IDistantAction distantAction;

        public Ratul(ICloseAction CloseAction)
        {
            this.closeAction = CloseAction;
        }

        public Ratul(IDistantAction DistantAction)
        {
            this.distantAction = DistantAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.TakeCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.TakeDistantAction();
        }
    }
}
