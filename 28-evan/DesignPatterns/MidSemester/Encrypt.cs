namespace DesignPatterns.MidSemester
{

	public class Encrypt : File_Decorator
	{
		public Encrypt(IGamerStat gamerStat): base(gamerStat)
		{
		
		}
		
		protected override string selfFileRead(string text)
		{
		
			return text.ToLower();
		}
	}
}