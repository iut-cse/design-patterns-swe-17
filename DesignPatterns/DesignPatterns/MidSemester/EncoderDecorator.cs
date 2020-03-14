namespace DesignPatterns.MidSemester
{
    public class EncoderDecor : BaseDecorator
    {
        public EncoderDecor(IGamerStat Base) : base(Base)
        {

        }

        public override string statistics(string inStat)
        {
            string container;
            container = "(" + ToBeCoated.statistics(inStat) + ")";

            return container;
        }
    }
}