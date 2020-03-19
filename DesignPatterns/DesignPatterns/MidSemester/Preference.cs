using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private static Preference instance = null;
        string key;
        string value;
        Dictionary<string, string> dict = new Dictionary<string, string>();

        private Preference() { }

        public static Preference getobject()
        {
            if (instance == null)
            {
                instance = new Preference();
            }
            return instance;
        }

        public void setpreferecne(string key, string value)
        {
            dict[key] = value;
        }

        public string getpreference(string key)
        {
            return dict[key];
        }
    }
}
