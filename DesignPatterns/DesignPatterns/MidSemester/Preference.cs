using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private static Preference instance;
        private IDictionary<string, string> dict = new Dictionary<string, string>();
        private Preference()
        {

        }
        public void setPreference(string key, string value)
        {
            dict[key] = value;
        }
        public string getPreference(string key)
        {
            return dict[key];
        }
        public static Preference GetInstance()
        {
            if (instance == null)
                instance = new Preference();
            return instance;
        }
    }
}
