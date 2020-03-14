namespace DesignPatterns.MidSemester.Problem_2
{
    public class Uppercase : ConversionDecorator
    {
        public Uppercase(IConverter wrappee) : base(wrappee)
        {
            this.wrappee = wrappee;
        }
        public override string SelfConvert(string data)
        {
            data = data.ToUpper();
            return data;
        }


    }
}
