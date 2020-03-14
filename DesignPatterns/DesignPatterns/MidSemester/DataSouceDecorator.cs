namespace DesignPatterns.MidSemester
{
    public class DataSourceDecorator : DataSource
    {
        protected DataSource wrapee;

        public DataSourceDecorator(DataSource wrapee)
        {
            this.wrapee = wrapee;
        }

        public string convertion(string data)
        {
            return wrapee.convertion(data);
        }
    }
}