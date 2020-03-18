using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public partial class Ratul
    {

        ICloseAction CloseAction = null;
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
            return CloseAction.action();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
           
            return distantAction.TemplateMethod();
        }


    }
}
