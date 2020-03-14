using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        IDictionary<string, string> keyVal = new Dictionary<string, string>();
        // TODO: implement

        private static Preference instance;
        private static readonly object acquireLock = new object();

        private Preference()
        {
        }

        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (acquireLock)
                {
                    if (instance == null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;
        }

        public void setPreference(string key, string value)
        {
            if (keyVal.ContainsKey(key))
            {
                keyVal.Remove(key);
            }
            keyVal.Add(key, value);
        }

        public string getPreference(string key)
        {
            return keyVal[key];
        }

    }
}
