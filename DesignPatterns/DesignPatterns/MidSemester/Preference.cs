namespace DesignPatterns.MidSemester
{
    public class Preference
    {

        private static Preference preference;

        private static readonly object oneLock = new object();

        private string value, key;
        private Preference()

        { 

        }
        public static Preference getInstance()
        {
            if (preference == null)
            {
                lock(oneLock)
                {
                    if(preference==null)
                    {
                        preference = new Preference();
                    }
                }
            }
            return preference;


        }
        public void setPreference(string key, string value)

        {

            this.value = value;

            this.key = key;



        }

        public string getPreference(string key)
        {
            if(key.Equals(key))
            {
                return value;
            }
            else
            {
                return "null";
            }
        }


    }
}
