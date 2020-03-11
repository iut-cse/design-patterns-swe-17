using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private static Preference instance;
        private static readonly object padlock = new object();

        private Dictionary<string, string> dict = new Dictionary<string, string>();

        private Preference() { }
        public static Preference getInstance()
        {
            if(instance == null)
            {
                lock(padlock)
                {
                    if(instance == null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;
        }
        public void setPreference(string key, string value)
        {
            if (!dict.ContainsKey(key))
            { 
                dict.Add(key, value);
            }
            else
            {
                dict[key] = value;
            }
        }
        public string getPreference(string key)
        {
            return dict[key];
        }
    }
}
