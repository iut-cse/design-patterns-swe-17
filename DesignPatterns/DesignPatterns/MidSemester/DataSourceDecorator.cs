namespace DesignPatterns.MidSemester
{
    public class DataSourceDecorator : DataSource
    {
        public DataSource wrapee;
        public DataSourceDecorator(DataSource wrapee)
        {
            this.wrapee = wrapee;
        }
        public virtual string Convert(string data)
        {
            return wrapee.Convert(data);
        }
    }

}
