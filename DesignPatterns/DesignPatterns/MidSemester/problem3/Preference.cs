namespace DesignPatterns.MidSemester.problem3
{
    public class Preference
    {
        // TODO: implement

        private static Preference instance;
        private static readonly object adlock = new object();

        string key, value;

        private Preference() { }


        public static Preference GetInstance()
        {
            if(instance == null)
            {
                lock (adlock)
                {
                    if(instance== null)
                    {
                        instance = new Preference();
                    }
                }
            }
            return instance;
        }

        public void setPreference(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string GetPreference(string key)
        {
            return value;

        }

    }
}
