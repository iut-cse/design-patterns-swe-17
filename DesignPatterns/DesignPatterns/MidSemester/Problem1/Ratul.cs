using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        private readonly ICloseAction closeAction;
        private readonly IDistantAction distantAction;

        public Ratul(ICloseAction closeAction, IDistantAction distantAction)
        {
            this.closeAction = closeAction;
            this.distantAction = distantAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.Execute();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return distantAction.Execute();
        }
    }
}
