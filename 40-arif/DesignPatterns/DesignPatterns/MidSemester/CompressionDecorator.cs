namespace DesignPatterns.MidSemester
{
    public class CompressionDecorator : DataDecorator
    {
        public string data;
        public CompressionDecorator(DataDecorator source)
        {
            if (source.getData().Length >= 3)
            {
                this.data = source.getData().Remove(source.getData().Length - 2);
            }
            else
            {
                this.data = source.getData();
            }
        }

        public override string getData()
        {
            return this.data;
        }
    }
}