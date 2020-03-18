using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        
        private Preference() { }

        private static Preference instance;

     
        private IDictionary<string, string> list = new Dictionary<string, string>();
        private static readonly object ThreadLock = new object();
         public static Preference GetInstance()
        {

            if (instance == null)
            {
                lock (ThreadLock) ;
                if (instance == null)

                {
                    instance = new Preference();
                }
            }
            return instance;
        }


        public void setPreference(string key, string value)
        {
            list[key] = value;
        }

        public string getPreference(string key)
        {
            return list[key]; 
        }




    }
}
