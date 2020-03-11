namespace DesignPatterns.MidSemester
{
    public class EncodeDecorator : DataDecorator
    {
        public string data;
        public EncodeDecorator(DataDecorator source)
        {
            this.data = "("+source.getData()+")";
        }

        public override string getData()
        {
            return this.data;
        }
    }
}
