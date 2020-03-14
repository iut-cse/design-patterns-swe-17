using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem_1
{
	public abstract class DistantAction 
	{
		public IEnumerable<string> ExecuteDistantAction()
        {
			return new[] { Move(), Grab(), Hit() };
        }
		private string Move()
        {
			return "move";
        }

		public abstract string Grab();
		public abstract string Hit();
		
	}
}

