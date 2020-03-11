namespace DesignPatterns.MidSemester
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source)
        {
        }

        public string writeData(string data)
        {
            // 1. Encrypt passed data.
            // 2. Pass encrypted data to the wrappee's writeData // method.
            return data;
        }
        public string readData()
        {

            // 1. Get data from the wrappee's readData method. // 2. Try to decrypt it if it's encrypted.
            // 3. Return the result.

            return "";
        }
    }
}
