using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static readonly object ThreadLock = new object();
        private Dictionary<string, string> dicton = new Dictionary<string, string>();

        private Preference()
        {

        }

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
            if (!dicton.ContainsKey(key))
            {
                dicton.Add(key, value);
            }

            else
            {
                dicton[key] = value;
            }
        }

        public string getPreference(string key)
        {
            return dicton[key];
        }
    }
}