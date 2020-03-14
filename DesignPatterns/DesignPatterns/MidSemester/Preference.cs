using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static readonly object ThreadLock = new object();
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        private Preference() { }

        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (ThreadLock)
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
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
            }

            else
            {
                dictionary[key] = value;
            }
        }

        public string getPreference(string key)
        {
            return dictionary[key];
        }

    }
}
