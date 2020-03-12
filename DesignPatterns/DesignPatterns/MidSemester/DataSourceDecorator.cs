namespace DesignPatterns.MidSemester
{
    public class DataSourceDecorator : DataSource
    {
        public DataSource wrapee;

        public DataSourceDecorator(DataSource wrapee)
        {
            this.wrapee = wrapee;
        }
        public virtual string convertion(string data)
        {
            return wrapee.convertion(data);
        }
    }

   
}
