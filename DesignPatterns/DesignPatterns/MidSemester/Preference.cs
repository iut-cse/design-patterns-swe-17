using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        IDictionary<string, string> keyValue = new Dictionary<string, string>();
        private static Preference instance;
        private static readonly object locking = new object();

        private Preference()
        {

        }
        public void setPreference(string key, string value)
        {
            if (keyValue.ContainsKey(key))
            {
                keyValue.Remove(key);
            }
            keyValue.Add(key, value);
        }
        public string getPreference(string key)
        {
            return keyValue[key];
        }
        
        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (locking)
                {
                    if (instance == null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;
        }
    }
}
