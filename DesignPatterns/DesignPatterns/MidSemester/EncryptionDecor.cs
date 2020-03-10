namespace DesignPatterns.MidSemester
{
    public class EncryptionDecor : BaseDecor
    {
        public EncryptionDecor(IStatSaver Base) : base(Base)
        {

        }

        public override string statistics(string inStat)
        {
            string container;
            container = ToBeCoated.statistics(inStat).ToLower();

            return container;
        }
    }
}
