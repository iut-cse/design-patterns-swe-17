using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    //using System;
    public class Preference1
    {
        private Preference1() { }
        private static Preference1 instance;
        //private static readonly object _lock = new object();
        private IDictionary<string, string> dic = new Dictionary<string, string>();
        public static Preference GetInstance()
        {
            if (instance == null)
            {
                instance = new Preference1();
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
Aa
