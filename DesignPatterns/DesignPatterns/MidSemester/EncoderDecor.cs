namespace DesignPatterns.MidSemester
{
    public class EncoderDecor : BaseDecor
    {
        public EncoderDecor(IStatSaver Base) : base(Base)
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
