namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        string key;
        string value;
        static readonly object pblock = new object();
        private Preference()
        {
        }
        private static Preference instance = null;
        public static Preference Instance
        {
            get
            {
                lock (pblock)
                {
                    if (instance == null)
                    {
                        instance = new Preference();
                    }
                    return instance;
                }
            }
        }
        public void setPreference(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
        public string getPreference(string key)
        {
            return value;
        }
    }
}
