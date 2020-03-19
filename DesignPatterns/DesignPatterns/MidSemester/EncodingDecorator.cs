namespace DesignPatterns.MidSemester
{
    public class EncodingDecorator : DataSourceDecorator
    {
        public EncodingDecorator(DataSource wrapee) : base(wrapee) { }
        public override string Convert(string data)
        {
            return "(" + wrapee.Convert(data) + ")";
        }
    }

}
