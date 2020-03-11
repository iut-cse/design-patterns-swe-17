namespace DesignPatterns.MidSemester
{
    public class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;

        public DataSourceDecorator(IDataSource source)
        {
            this.wrappee = source;
        }

        public string writeData(string data)
        {
            this.wrappee.writeData(data);

            return data;
        }
        public string readData()
        {
            return wrappee.readData();
        }
    }

}