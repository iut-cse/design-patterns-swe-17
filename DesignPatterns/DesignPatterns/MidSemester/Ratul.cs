using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public partial class Ratul
    {
        ICloseAction CloseAction=null;
        IDistantAction distantAction = null;
        public Ratul(ICloseAction CloseAction)
        {
            this.CloseAction = CloseAction;
        }
        public Ratul(IDistantAction distantAction)
        {
            this.distantAction = distantAction;
        }

        public string ExecuteCloseAction()
        {
            return CloseAction.action() ;
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.TemplateMethod();
        }
    }
}
