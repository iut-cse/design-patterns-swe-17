using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        readonly ICloseAction closeAction;
        readonly IDistantAction distantAction;

        public Ratul(ICloseAction closeAction)
        {
            this.closeAction = closeAction;
        }

        public Ratul(IDistantAction distantAction)
        {
            this.distantAction = distantAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.CloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return distantAction.DistantAction();
        }
    }
}
