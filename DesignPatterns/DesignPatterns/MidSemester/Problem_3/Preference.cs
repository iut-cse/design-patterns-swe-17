using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem_3
{
    public class Preference
    {

        // TODO: implement
        IDictionary<string, string> pref = new Dictionary<string, string>();
        private Preference()
        {

        }
        private static Preference Instance = null;
        private static readonly object _lock = new object() ;

        public static Preference getInstance()
        {
            if (Instance == null)
            {
                lock (_lock) ;
                {
                    if(Instance==null)
                    {
                        Instance = new Preference();
                    }
                }
            }
            return Instance;
        }

        public void SetPreference(string key , string value)
        {
            pref[key] = value;
        }

        public string GetPreference(string key)
        {
            return pref[key];
        }
    }
}
