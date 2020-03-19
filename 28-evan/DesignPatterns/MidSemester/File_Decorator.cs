namespace DesignPatterns.MidSemester
{

	public abstract class File_Decorator : IGamerStat
	{
		private readonly IGamerStat gamerStat;
		
		public File_Decorator(IGamerStat gamerStat)
		{
			this.gamerStat=gamerStat;
		}
		public string fileRead(string text)
		{
			text = selfFileRead(text);
			return gamerStat.fileRead(text);
		}

		protected abstract string selfFileRead(string text);

	}
}