using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference uniqueInstance;
        IDictionary<string, string> preference = new Dictionary<string, string>();

        private static readonly object _lock = new object();

        private Preference() {}
        public static Preference getInstance()
        {
            if (uniqueInstance == null)
            {
                lock (_lock)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Preference();
                    }
                    
                }
            }
            return uniqueInstance;
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
