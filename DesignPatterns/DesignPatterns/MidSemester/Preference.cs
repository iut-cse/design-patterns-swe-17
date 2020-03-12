using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference preference;
        private Dictionary<string,string> dictionary = new Dictionary<string, string>();
        private static readonly object Thread = new object(); //skipping the hassle of ReadWriterLockSlim

        private Preference()
        {}

        public static Preference Instantiate()
        {
            if(preference == null)
            {
                lock(Thread)
                {
                    if(preference == null)
                    {
                        preference = new Preference();
                    }
                }
            }
            return preference;
        }

        public void setPreference(string key , string value)
        {
            if (!(dictionary.ContainsKey(key)))
            {
                dictionary.Add(key, value);
            }
            else
                dictionary[key] = value;
        }

        public string getPreference(string key)
        {
            return dictionary[key];
        }
    }
}
