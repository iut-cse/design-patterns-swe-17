namespace DesignPatterns.MidSemester
{
    public class Encode : FileDecorator
    {
        public Encode(IGamerStat gamerStat) : base(gamerStat)
        {

        }


        protected override string selfFileRead(string text)
        {
            return "(" + text + ")";
        }
    }
}
