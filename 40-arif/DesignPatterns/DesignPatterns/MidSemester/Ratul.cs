using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        ICloseAction closeAction;
        DistantAction distantAction;

        public Ratul(ICloseAction closeAction, DistantAction distantAction)
        {
            this.closeAction = closeAction;
            this.distantAction = distantAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.ExecuteAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return distantAction.ExecuteAction();
        }
    }
}