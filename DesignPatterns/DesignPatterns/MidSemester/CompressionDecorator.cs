namespace DesignPatterns.MidSemester
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrapee) : base(wrapee) { }
        public override string Convert(string data)
        {
            int len = wrapee.Convert(data).Length;

            if (len < 3)
            {
                return wrapee.Convert(data);
            }
            else
            {
                return wrapee.Convert(data).Substring(0, len - 2);
            }
        }
    }

}
