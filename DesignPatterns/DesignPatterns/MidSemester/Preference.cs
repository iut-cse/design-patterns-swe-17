using System;

namespace DesignPatterns.MidSemester
{
    public sealed class Preference
    {
        private static System.Collections.Generic.IDictionary<string, string> dict = new System.Collections.Generic.Dictionary<string, string>();
        private static Preference instance = null;
        public static Preference GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Preference();
                return instance;
            }
        }

        private Preference()
        {

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
