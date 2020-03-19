namespace DesignPatterns.MidSemester.Problem2
{
    public class Encryption : CDecorator{
        public Encryption(IConverter wrappee) : base(wrappee){
        }
        public override string Converter(string mydata){
            data = data.ToLower();
            return base.Converter(mydata);
        }
    }
}