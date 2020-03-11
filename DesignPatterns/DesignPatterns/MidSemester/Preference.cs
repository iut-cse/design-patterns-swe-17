using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static object threadlock = new object();
        private IDictionary<string, string> dict = new Dictionary<string, string>();

        private Preference()
        {

        }
        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (threadlock)
                {
                    if (instance == null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;
        }
        public void setPreference(String key, String value)
        {
            dict[key] = value;
        }
        public String getPreference(String key)
        {
            return dict[key];
        }
    }
}