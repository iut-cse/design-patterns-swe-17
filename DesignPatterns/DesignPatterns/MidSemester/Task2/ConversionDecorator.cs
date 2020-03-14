namespace DesignPatterns.MidSemester.Task2
{
    public abstract class ConversionDecorator : IConverter
    {
        protected IConverter wrapee;

        public ConversionDecorator(IConverter wrapee)
        {
            this.wrapee = wrapee;
        }

        public string Convert(string data)
        {
            data = SelfConvert(data);
            return wrapee.Convert(data);
        }
        public abstract string SelfConvert(string data);

    }
}
