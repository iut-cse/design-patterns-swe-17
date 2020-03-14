namespace DesignPatterns.MidSemester
{
    public class EncodingDecorator : DataSourceDecorator
    {
        public EncodingDecorator(DataSource wrapee) : base(wrapee)
        { 
        
        }
        public override string convertion(string data)
        {
            return "(" + wrapee.convertion(data) + ")";
        }
    }
}