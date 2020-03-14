namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encrypt : ConversionDecorator
    {
        public Encrypt(IConverter wrappee) : base(wrappee)
        {
            this.wrappee = wrappee;

        }
        public override string SelfConvert(string data)
        {
            data = data.ToLower();
            return data;
        }
    }
}
