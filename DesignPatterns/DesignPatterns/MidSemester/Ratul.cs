using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        private CloseAction closeaction;
        private DistantAction distantaction;

        public Ratul(CloseAction closeaction, DistantAction distantaction)
        {
            this.closeaction = closeaction;
            this.distantaction = distantaction;
        }



        public string ExecuteCloseAction()
        {
            return closeaction.ExecuteCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantaction.ExecuteDistantAction();
        }
    }
}
