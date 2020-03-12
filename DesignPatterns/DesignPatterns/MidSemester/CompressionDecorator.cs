namespace DesignPatterns.MidSemester
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrapee) : base(wrapee) { }
        public override string convertion(string data)
        {
            int len = wrapee.convertion(data).Length;

            if (len < 3)
            {
                return wrapee.convertion(data);
            }
            else
            {
                return wrapee.convertion(data).Substring(0, len-2);
            }
        }
    }
}
