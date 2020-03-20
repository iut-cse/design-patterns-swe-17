namespace DesignPatterns.MidSemester.Problem2
{
    public class Encoder : CDecorator
    {
        public Encoder(IConv wrappee) : base(wrappee)
        {
        }
        public override string Converter(string mydata)
        {
            mydata = "(" + mydata + ")";
            return base.Converter(mydata);
        }
    }
}