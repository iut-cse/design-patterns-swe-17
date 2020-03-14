namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference preference;
        private static readonly object Lock = new object();
        private string checkvalue,checkkey;

        private Preference()
        {

        }

        public static Preference getInstance()
        {
            if (preference == null)
            {
                lock (Lock)
                {
                    if (preference == null)
                    {
                        preference = new Preference();
                    }
                }
            }
            return preference;
        }
        public void setPreference(string key,string value)
        {
            checkvalue = value;
            checkkey = key;

        }

       public string getPreference(string key)
        {
            if(key.Equals(checkkey))
            {
                return checkvalue;
            }
            else
            {
                return "null";
            }
        }


    }
}
