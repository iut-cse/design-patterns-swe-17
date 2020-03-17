using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static object locker=new object();
        private Dictionary <string,string> storage;

        public static Preference GetInstance()
        {
            if(instance==null)
            {
                lock(locker)
            {
                if(instance==null)
                   instance=new Preference();

            }

            }

            return instance;
        }

        private Preference()
        {
            storage=new Dictionary <string,string>();
        }

        public void SetPreference(string key,string value)
        {
            storage[key]=value;
        }

        public string GetPreference(string key)
        {
            return storage[key];
        }
    }
}
