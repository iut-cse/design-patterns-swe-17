namespace DesignPatterns.MidSemester
{
    public class ConvertionDecorator : IConverter
    {
        private readonly IConverter wrappee;

        public ConvertionDecorator(IConverter wrappee)
        {
            this.wrappee = wrappee;
        }
        public virtual string Convert(string data)
        {
            return wrappee.Convert(data);
        }
    }
}
