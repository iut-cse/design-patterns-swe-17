using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private List<string> list;

        
        private Preference()
        {

        }
        public static Preference getInstance()
        {
            if (instance == null)
            {
                //acquireThreadLock();
                if (instance == null)
                {
                    instance = new Preference();
                }
            }
            return instance;
        }


        public void setPreference(string key, string val)
        {
            
        }

        public string getPreference(string key)
        {
            return "get";
        }
    }
}
