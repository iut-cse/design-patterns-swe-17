namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        // TODO: implement
        private Preference()
        {
        }
        private static Preference instance=null;
        private static readonly object padlock=new object();
        public static Preference GetInstance()
        {
            if(instance==null)
            {
                lock (padlock)
                {
                    if(instance==null)
                        instance=new Preference();
                    }
            }              
            return instance;
        }
        public string key;
        public string value;
        public void SetPreference(string key,string value){
            this.key=key;
            this.value=value;
        }
        public string GetPreference(string key){
            return value;
        }
    }
}
