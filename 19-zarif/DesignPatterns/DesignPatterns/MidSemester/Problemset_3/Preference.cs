namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference preference;
        private static readonly object Lock = new object();
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
        void setPreference(string key,string value)
        {

        }

       

    }
}
