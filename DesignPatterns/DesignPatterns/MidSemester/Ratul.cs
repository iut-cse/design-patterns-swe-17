using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        Action action;
        public Ratul(Action action)
        {
            this.action = action;
        }
        public string ExecuteCloseAction()
        {
            List<string> ls = (List<string>)action.ExecuteAction();
            return ls[0];
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return action.ExecuteAction();
        }
    }
}
