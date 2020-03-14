namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encoder : ConversionDecorator
    {
        //private readonly IConverter wrappee;
        public Encoder(IConverter wrappee) : base(wrappee)
        {
            this.wrappee = wrappee;
        }
        public override string SelfConvert(string data)
        {
            data = "(" + data + ")";
            return data;
        }
    }

}
