using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference preferenceInstance;
        Dictionary<string, string> preference = new Dictionary<string, string>();

        private static readonly object _lock = new object();

        private Preference()
        {

        }

        public static Preference GetpreferenceInstance()
        {
            if (preferenceInstance == null)
            {
                lock (_lock)
                {
                    if (preferenceInstance == null)
                    {
                        preferenceInstance = new Preference();
                    }

                }
            }
            return preferenceInstance;
        }

        public void setPreference(string key,string value)
        {
            if (preference.ContainsKey(key))
            {
                preference.Remove(key);
            }
            preference[key] = value;
        }

        public string getPreference(string key)
        {
            return preference[key];
        }
    }
}
