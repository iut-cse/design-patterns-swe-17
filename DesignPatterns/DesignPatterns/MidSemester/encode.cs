namespace DesignPatterns.MidSemester
{
    public class encode
    {
        public class encode : filedecorator

        {

            public encode(IGamerStat gamerStat) : base(gamerStat)

            {



            }





            protected override string selfFileRead(string text)

            {

                return "(" + text + ")";

            }

        }
    }
}



