using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public  class Preference
    {
        private static Preference instance;
        string key, value;
        Dictionary<string, string> dict =new Dictionary<string, string>();

        private Preference() { }
        public static Preference  getInstance()
        {
            if (instance == null)
            {
                instance = new Preference();
            }
            return instance;
        }
        public void setPreference(string key,string value)
        {
            dict[key] = value;
        }
        public  string getPreference(string key)
        {
            return dict[key]; 
        }
        

        
    }
}
