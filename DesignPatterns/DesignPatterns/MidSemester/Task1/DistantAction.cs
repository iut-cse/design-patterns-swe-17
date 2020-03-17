namespace DesignPatterns.MidSemester.Task1
{

	public abstract class DistantAction
	{
		public string Move()
		{
			return "Move";
		}
		public abstract string Grab();
		public abstract string Hit();
		public IEnumerable<string> ExecuteDistantAction()
		{	
			yield return Move();
			yield return Grab();
			yield return Hit();

		}
	}
}