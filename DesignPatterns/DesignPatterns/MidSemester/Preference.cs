using Amazon.EC2.Model;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static object ThreadLock = new object();
        private static Preference instance;
        private string TheKey;
        private string TheValue;
        private Dictionary<string, string> storage;

        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (ThreadLock)
                {
                    {
                        if (instance == null)
                            instance = new Preference();
                    }
                }
            }

            return instance;
        }

        private Preference()
        {
            storage = new Dictionary<string, string>();
        }


        public void setPreference(string key, string value)
        {
            TheKey = key;
            TheValue = value;
        }

        public string getPreference(string key)
        {
            if (key.Equals(TheKey))
            {
                return TheValue;
            }

            else
            {
                return "null";
            }
        }
    }
}
