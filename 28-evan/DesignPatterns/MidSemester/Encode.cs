namespace DesignPatterns.MidSemester
{

	public class Encode : File_Decorator
	{
		public Encode(IGamerStat gamerStat): base(gamerStat)
		{
		
		}
		
		protected override string selfFileRead(string text)
		{
		
			return "(" +text+ ")";
		}
	}
}