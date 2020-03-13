using DesignPatterns.MidSemester.Problemset_1;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        private IcloseAction icloseaction;
        private DistantAction distantactions;

        public string ExecuteCloseAction()
        {
            return icloseaction.ExecuteCloseAction();
        }
        public Ratul(IcloseAction icloseaction,DistantAction distantAction)

        {
            this.icloseaction = icloseaction;
            distantactions = distantAction;

        }
        public IEnumerable<string> ExecuteDistantAction()
        {
            
            return distantactions.ExecuteDistantAction();
        }
    }
}
