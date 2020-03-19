namespace DesignPatterns.MidSemester
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource wrapee) : base(wrapee) { }
        public override string Convert(string data)
        {
            return wrapee.Convert(data).ToLower();
        }
    }

}
