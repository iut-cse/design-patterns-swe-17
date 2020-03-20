using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem3
{
    public class Preference
    {
        private static Preference instance;
        private static object locker = new object();
        public static Preference GetInstance()
        {
            if (instance == null)
                lock (locker)
                    if (instance == null)
                        instance = new Preference();

            return instance;
        }

        private Dictionary<string, string> storage;

        private Preference()
        {
            storage = new Dictionary<string, string>();
        }

        public string GetPreference(string key)
        {
            return storage[key];
        }

        public void SetPreference(string key, string value)
        {
            storage[key] = value;
        }
    }
}
