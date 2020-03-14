using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public sealed class Preference
    {
        private static volatile Preference instance;
        private Dictionary<string,string> map = new Dictionary<string, string>();
        private static readonly object syncRoot = new object();

        private Preference()
        {
            
        }
        public static Preference getInstance()
        {
            Preference result = instance;
            if (result == null)
            {
                lock(syncRoot) {
                    result = instance;
                    if (result == null)
                        instance = result = new Preference();
                }
            }
            return result;
            
            
        }

        public void setPreference(string key, string value)
        {
            if (!(map.ContainsKey(key)))
            {
                map.Add(key, value);
            }
        }

        public string getPreference(string key)
        {
            return map[key] ;
        }
    }
}
