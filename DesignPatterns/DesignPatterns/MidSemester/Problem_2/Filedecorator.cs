namespace DesignPatterns.MidSemester
{
    public abstract class FileDecorator : IGamerStat
    {
        private readonly IGamerStat gamerStat;
        public FileDecorator(IGamerStat gamerStat)
        {
            this.gamerStat = gamerStat;
        }
        public string fileRead(string text)
        {
            text = selfFileRead(text);
            return gamerStat.fileRead(text);
        }

        protected abstract string selfFileRead(string text);
    }
}
