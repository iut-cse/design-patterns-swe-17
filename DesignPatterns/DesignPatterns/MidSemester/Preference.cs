namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference preference = null;
        private static readonly object padlock = new object();
        string key, value;
       
        private Preference(){
        }
        public static Preference getInstance()
        {
            if(preference==null)
            {
                lock (padlock)
                {
                    if (preference == null)
                    {

                        preference = new Preference();
                    }
                }
            }
            
            
            return preference;
        }
        public void SetPreference(string value, string key)
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
