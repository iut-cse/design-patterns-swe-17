namespace DesignPatterns.MidSemester
{
    public class Decorator : DataDecorator
    {
        public string data;

        public Decorator(string data)
        {
            this.data= data;
        }

        public override string getData()
        {
            return this.data;
        }
    }
}