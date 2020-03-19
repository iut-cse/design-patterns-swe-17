using System.Collections.Generic;

namespace DesignPatterns.MidSemester..Problem1
{
    public class Ratul
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
