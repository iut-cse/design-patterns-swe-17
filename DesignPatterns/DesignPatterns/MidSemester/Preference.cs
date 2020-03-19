namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        string mykey, myvalue;
        private static Preference preference;
        private static readonly object Lock = new object();

        private Preference()
        {
        }
        public static Preference getInstance()
        {
            if (preference == null)
            {
                lock (Lock)
                {
                    if (preference == null)
                    {
                        preference = new Preference();
                    }
                }
            }
            return preference;
        }
        public string getPreference(string key)
        {
            if (key.Equals(key))
            {
                return value;
            }
            else
            {
                return "null";
            }
        }
        public void setPreference(string key, string value)
        {
            mykey = key;
            myvalue = value;
        }
    }
}