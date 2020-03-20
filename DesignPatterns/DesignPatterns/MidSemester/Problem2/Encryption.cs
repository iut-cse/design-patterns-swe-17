namespace DesignPatterns.MidSemester.Problem2
{
    public class Encryption : CDecorator
    {
        public Encryption(IConv wrappee) : base(wrappee)
        {
        }
        public override string Converter(string mydata)
        {
            mydata = mydata.ToLower();
            return base.Converter(mydata);
        }
    }
}