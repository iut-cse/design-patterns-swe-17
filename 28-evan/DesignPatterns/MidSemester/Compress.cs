namespace DesignPatterns.MidSemester
{

	public class Compress : File_Decorator
	{
		public Compress(IGamerStat gamerStat): base(gamerStat)
		{
		
		}
		
		protected override string selfFileRead(string text)
		{
			if(text.Length >= 3)
			{
				text = text.Substring(0, text.Length - 2);
			}
			
			return text;
		}
	}
}