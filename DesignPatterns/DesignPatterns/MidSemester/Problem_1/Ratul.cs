using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        private I_CloseAction closeAction;
        private Distant_action distant_Action;
        public Ratul(I_CloseAction closeAction, Distant_action distant_Action)
        {
            this.closeAction = closeAction;
            this.distant_Action = distant_Action;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.execute_hit();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
           
            return distant_Action.distant_template();
        }
    }
}
