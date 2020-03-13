using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        ICloseAction CloseAction=null;
        IDistantAction DistantAction = null;

        public Ratul(ICloseAction CloseAction)
        {
            this.CloseAction = CloseAction;
        }
        public Ratul(IDistantAction DistantAction)
        {
            this.DistantAction = DistantAction;
        }

        public string ExecuteCloseAction()
        {
            return CloseAction.action() ;
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return DistantAction.ExecuteAction();
        }
    }
}