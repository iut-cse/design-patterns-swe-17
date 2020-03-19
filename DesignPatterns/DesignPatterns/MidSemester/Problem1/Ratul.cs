using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul.Problem1
    {
        private DistantAction DistantAction;
        private ICloseAction ICloseAction;

        public Ratul(ICloseAction ICloseAction, DistantAction DistantAction)
        {
            this.ICloseAction = ICloseAction;
            this.DistantAction = DistantAction;
        }
        public IEnumerable<string> ExecuteDistantAction()
        {
            return DistantAction.ExecuteDistantAction();
        }
        public string ExecuteCloseAction()
        {
            return ICloseAction.ExecuteCloseAction();
        }
    }
}
