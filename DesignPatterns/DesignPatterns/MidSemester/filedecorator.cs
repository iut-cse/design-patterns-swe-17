namespace DesignPatterns.MidSemester
{
    public class filedecorator : IGamerStat
    {
         {

        private readonly IGamerStat gamerStat;

        public fileDecorator(IGamerStat gamerStat)

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
}



