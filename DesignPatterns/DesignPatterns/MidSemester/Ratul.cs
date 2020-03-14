using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        public string ExecuteCloseAction(ICloseAction closeAction)
        {
            return closeAction.performCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction(IDistantAction distantAction)
        {
            
            return distantAction.PerformDistantaction();
        }
    }
}
