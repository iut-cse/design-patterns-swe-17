namespace DesignPatterns.MidSemester.Task2
{
    public class Uppercase : ConversionDecorator
    {
        public Uppercase(IConverter wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public override string SelfConvert(string data)
        {
            data = data.ToUpper();
            return data;
        }
    }
}
