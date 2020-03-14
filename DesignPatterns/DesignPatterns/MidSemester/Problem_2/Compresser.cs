namespace DesignPatterns.MidSemester.Problem_2
{
    public class Compresser : ConversionDecorator
    {
        public Compresser(IConverter wrappee) : base(wrappee)
        {
            this.wrappee = wrappee;
        }
        public override string SelfConvert(string data)
        {
            if (data.Length >= 3)
            {
                data = data.Substring(0, data.Length - 2);
            }
            return data;
        }
    }
}
