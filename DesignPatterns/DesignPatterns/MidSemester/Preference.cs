using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    //using System;
    public class Preference
    {
        private Preference() { }

        private static Preference instance;


        private static readonly object _lock = new object();
        private IDictionary<string, string> dic = new Dictionary<string, string>();

        public static Preference GetInstance()
        {

            if (instance == null)
            {
                instance = new Preference();
            }
            return instance;
        }


        public void setPreference(string key, string value)
        {
            dic[key] = value;
        }
        public string getPreference(string key)
        {
            return dic[key]; 
        }
    }
}
