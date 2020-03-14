namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;
        private static object threadLock = new object();
        private string value = null;
        private string key = null;


        public Preference()
        {

        }

        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (threadLock)
                {

                    {
                        if (instance == null)
                            instance = new Preference();
                    }
                }
            }

            return instance;
        }

        public void SetPreference(string key, string value)
        {
            if (key == instance.key)
            {
                instance.value = value;
            }

            else if (instance.key == null)
            {
                instance.key = key;
                instance.value = value;
            }
        }

        public string GetPreference(string key)
        {
            if (key == instance.key)
                return instance.value;

            return null;
        }

    }
}
