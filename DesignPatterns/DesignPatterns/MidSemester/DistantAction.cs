using System.Collections;

namespace DesignPatterns.MidSemester
{
	public abstract class DistantAction
    {
		public string move()
        {
			return "Move to enemy";
        }
		public abstract string grab();
		public abstract string hit();

		public IEnumerable<string> execute()
        {
            return new[] { move(), grab(), hit() };
        }
    }
}
