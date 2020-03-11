namespace DesignPatterns.MidSemester
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource wrapee) : base(wrapee) { }
        public override string convertion(string data)
        {
            return wrapee.convertion(data).ToLower();
        }

    }
}
