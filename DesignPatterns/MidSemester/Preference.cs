namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static object ThreadLock = new object();
        private static Preference instance;
        private string TheKey;
        private string TheValue;

        private Preference()
        {

        }
        public Preference getInstance(string key,string value)
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

        public void setPreference(string key,string value)
        {
            TheKey = key;
            TheValue = value;
        }

        public string getPrefrence(string key)
        {
            if (key.Equals(TheKey))
                return TheValue;

            else
                return null;
        }





            
    }
}
