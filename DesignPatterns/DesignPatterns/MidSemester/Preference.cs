using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        IDictionary<string, string> preference = new Dictionary<string, string>();
        private static readonly object lockMethod = new object();
                
        private Preference()
        {
            
        }

        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (lockMethod)
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
            preference[key] = value;
        }

        public string getPreference(string key)
        {
            return preference[key];
        }

        // TODO: implement
    }
}
