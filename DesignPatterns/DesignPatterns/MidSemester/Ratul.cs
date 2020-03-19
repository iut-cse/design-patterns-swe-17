using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        public string ExecuteCloseAction()
        {
            public ICloseAction closeAction;
        public DistantAction distantAction;
        public List<string> ActionList = new List<string>();

        public Ratul(ICloseAction currentCloseAction, DistantAction currentDistantAction)
        {
            this.closeAction = currentCloseAction;
            this.distantAction = currentDistantAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.DoCloseAction();
        }
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
