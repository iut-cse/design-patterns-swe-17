using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_1
{
 
		public abstract class DistantAction
		{
		public IEnumerable<string> ExecuteDistantAction()
			{
				yield return Move();
				yield return Grab();
				yield return Hit();
			}
			private string Move()
			{
				return "move";
			}

			protected abstract string Grab();
			protected abstract string Hit();

		}
	}
