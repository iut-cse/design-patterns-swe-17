using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private volatile static Preference obj;
        Dictionary<string, string> preference = new Dictionary<string, string>();

        private Preference() { }

        public void setPreference(string key, string value)
        {
            preference.Add(key, value);
        }

        public string getPreference(string key)
        {
            return preference[key];
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Preference GetInstance()
        {
            if (obj == null)
                obj = new Preference();
            return obj;
        }
    }
}
