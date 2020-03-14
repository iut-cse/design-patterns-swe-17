using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        CloseAction closeaction;
        DistantAction distantaction;
        public string ExecuteCloseAction()
        {
            return null;
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            //test
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return null;
        }
    }
}
