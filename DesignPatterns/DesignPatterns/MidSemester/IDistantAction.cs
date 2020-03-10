using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface IDistantAction
    {
        public IEnumerable<string> TakeDistantAction();
        public string Move();
        public string Grab();
        public string Hit();
    }
}
