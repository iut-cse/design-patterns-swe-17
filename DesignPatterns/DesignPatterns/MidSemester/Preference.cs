using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private static Preference instance;

        private Preference()
        {

        }

        private IDictionary<string, string> dic = new Dictionary<string, string>();

        public static Preference getInstance()
        {
            if (instance == null)
            {
                instance = new Preference();
            }
            return instance;
        }

        public void setPreferance(string key, string value)
        {
            dic[key] = value;
        }

        public string getPreferance(string key)
        {
            return dic[key];
        }

    }
}
