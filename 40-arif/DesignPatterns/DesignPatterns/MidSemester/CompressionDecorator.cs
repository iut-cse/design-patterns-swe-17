namespace DesignPatterns.MidSemester
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public string data;
        public CompressionDecorator(IDataSource source) : base(source)
        {
            if (source.readData().Length >= 3)
            {
                this.data = source.readData().Remove(source.readData().Length - 2);
            }
            else
            {
                this.data = source.readData();
            }
        }

        public string writeData(string path)
        {
            if (source.readData().Length >= 3)
            {
                this.data = source.readData().Remove(source.readData().Length - 2);
            }
            else
            {
                this.data = source.readData();
            }
            return data;
        }

        public string readData()
        {
            return this.data;
        }
    }
}