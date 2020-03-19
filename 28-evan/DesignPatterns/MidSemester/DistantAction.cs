using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
	public abstract class DistantAction 
	{
		public IEnumerable<string> execute()
        {
			yield return Move();
			yield return Grab();
			yield return Hit();
        }
		private string Move()
        {
			return "move";
        }

		public abstract string Grab();
		public abstract string Hit();
		
	}
}

