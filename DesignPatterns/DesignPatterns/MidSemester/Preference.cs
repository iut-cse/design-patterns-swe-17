using System;
using System.Threading;

namespace DesignPatterns.MidSemester
{
    public sealed class Preference
    {
        private static System.Collections.Generic.IDictionary<string, string> dict;
        private static Preference instance = null;
        public static object target = new object();
        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (target)
                {
                    if (instance == null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;      
        }

        private Preference()
        {
            dict = new System.Collections.Generic.Dictionary<string, string>();
        }
        public void setPreference(string key, string value)
        {
            dict.Add(key, value);
        }

        public string getPreference(string key)
        {
            return dict[key];
        }
    }
}
