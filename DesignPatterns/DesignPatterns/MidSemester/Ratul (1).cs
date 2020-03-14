using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        CloseAction closeAction;
        DistantAction distantAction;
        
        public Ratul(CloseAction closeAction)
        {
            this.closeAction = closeAction;
        }
        public Ratul(DistantAction distantAction)
        {
            this.distantAction = distantAction;
        }
        public string ExecuteCloseAction()
        {
            
            return closeAction.execute();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
           
            return distantAction.act();

        }
    }
}
