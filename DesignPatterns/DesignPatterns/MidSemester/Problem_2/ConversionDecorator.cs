namespace DesignPatterns.MidSemester.Problem_2
{
    public abstract class ConversionDecorator : IConverter
    {
        protected IConverter wrappee;

        public ConversionDecorator(IConverter wrappee)
        {
            this.wrappee = wrappee;
        }

        public string Convert(string data)
        {
            data = SelfConvert(data);
            return wrappee.Convert(data);
        }
        public abstract string SelfConvert(string data);
    }
}
