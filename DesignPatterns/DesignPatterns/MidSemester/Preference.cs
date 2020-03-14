namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static readonly object threadLock = new object();
        public string key = null;
        public string value = null;

        private Preference()
        {
        }

        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (threadLock)
                {
                    if (instance == null)
                        instance = new Preference();
                }
            }
            return instance;
        }

        public void setPreference(string key, string value)
        {
            if (key == instance.key)
            {
                instance.value = value;
            }

            else if (instance.key == null)
            {
                instance.key = key;
                instance.value = value;
            }
        }

        public string getPreference(string key)
        {
            if (key == instance.key)
                return instance.value;

            return null;
        }
    }
}
