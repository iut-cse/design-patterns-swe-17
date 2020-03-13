using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        IClose_action close_action = null;

        IDistant_action distant_action = null;

        public Ratul(IClose_action close_action)
        {
            this.close_action = close_action;
        }
        public Ratul(IDistant_action distant_action)
        {
            this.distant_action = distant_action;
        }

        public string ExecuteCloseAction()
        {
            return close_action.action();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distant_action.Template_method();
        }
    }
}
