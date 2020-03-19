namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private string key;
        private string value;

        private Preference()
        { }

        private static readonly object padlock = new object();

        private static Preference instance = null;
        public static Preference Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Preference();
                        }
                    }
                }
                return instance;
            }
        }
       public void setPreference(string key,string value)
        {
            this.key = key;
            this.value = value;

        }
        public string getPreference(string key)
        {

            return value;
        }
    }
}
