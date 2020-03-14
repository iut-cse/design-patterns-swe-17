namespace DesignPatterns.MidSemester
{
    public class EncryptionDecor : BaseDecorator
    {
        public EncryptionDecor(IGamerStat Base) : base(Base)
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