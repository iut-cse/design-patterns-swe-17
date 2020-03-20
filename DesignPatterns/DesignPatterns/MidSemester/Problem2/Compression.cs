namespace DesignPatterns.MidSemester.Problem2
{
    public class Compression : CDecorator
    {
        public Compression(IConv wrappee) : base(wrappee)
        {
        }
        public override string Converter(string mydata)
        {
            if (mydata.Length >= 3)
            {
                mydata = mydata.Substring(0, mydata.Length - 2);
            }
            return base.Converter(mydata);
        }
    }
}
