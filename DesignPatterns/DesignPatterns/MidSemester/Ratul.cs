using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public partial class Ratul
    {
        public ICloseAction closeAction;
        public IDistantAction distantAction;

        public Ratul(ICloseAction closeAction, IDistantAction distantAction)
        {
            this.closeAction = closeAction;
            this.distantAction = distantAction;
        }
       
        public string ExecuteCloseAction()
        {
            return closeAction.performCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return distantAction.performDistantAction();
        }
    }
}
