using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference pref;
        private static readonly object padlock = new object();
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        private Preference() { }

        public static Preference getInstance()
        {
            if(pref == null)
            {
                lock(padlock)
                {
                    if(pref == null)
                    {
                        pref = new Preference();
                    }
                }
            }
            return pref;
        }

        public void SetPreference(string key, string value)
        {
            dict[key] = value;
        }

        public string GetPreference(string key)
        {
            if (dict.ContainsKey(key))
                return dict[key];
            else
                return null;
        }
    }
}
