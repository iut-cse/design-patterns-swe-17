namespace DesignPatterns.MidSemester
{
    public class encrypt : filedecorator
    {
        public encrypt(IGamerStat gamerStat) : base(gamerStat)

        {



        }



        protected override string selfFileRead(string text)

        {

            return text.ToLower();

        }

    }
}



