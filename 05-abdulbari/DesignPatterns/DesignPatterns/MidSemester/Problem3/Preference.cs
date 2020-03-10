using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        IDictionary<string, string> preference = new Dictionary<string, string>();
        private static readonly object aquireLock = new object();
        private Preference()
        {

        }
        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (aquireLock)
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
            if (preference.ContainsKey(key))
            {
                preference.Remove(key);
            }
            preference.Add(key, value);
        }
        public string getPreference(string key)
        {
            return preference[key];
        }

    }
}
