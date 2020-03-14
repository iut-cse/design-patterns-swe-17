using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem_3
{

    public class Preference
    {
        // TODO: implement
        private static Preference instance;
        IDictionary<string, string> preference = new Dictionary<string, string>();
        private static readonly object threadLock = new object();

        private Preference()
        {

        }
        public static Preference getInstance()
        {
            if(instance == null)
            {
                lock (threadLock)
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
            if (preference.ContainsKey(key))
            {

                preference.Remove(key);

            }
            preference.Add(key, value);

        }
        public string getPreference(string key)
        {
            return preference[key];
        }


    }
}
