namespace DesignPatterns.MidSemester
{
    public class Compress : ConversionDecorator
    {
        public Compress(IConverter wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }
        public override string SelfConvert(string data)
        {
            if (data.Length >= 3)
            {
                data = data.Substring(0, data.Length-2);
            }
            return data;
        }
    }
}
