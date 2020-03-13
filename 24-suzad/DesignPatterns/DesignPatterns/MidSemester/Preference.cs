using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        IDictionary<string, string> keyValue = new Dictionary<string, string>();
        private static Preference obj;
        private static readonly object locking = new object();
        // TODO: implement
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
        private Preference()
        {

        }
        public static Preference getObj()
        {
            if (obj == null)
            {
                lock (locking)
                {
                    if (obj == null)
                    {
                        obj = new Preference();
                    }
                }
            }
            return obj;
        }

    }
}
