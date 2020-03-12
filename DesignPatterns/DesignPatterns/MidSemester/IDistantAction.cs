using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public interface IDistantAction
    {
        public IEnumerable<string> performDistantAction();

        public string Move();
        public string Grab();
        public string Hit();

    }
}
