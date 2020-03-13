namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private string key = null, value = null;
        private static Preference _preference;
        private static readonly object _lock = new object();
        private Preference()
        {

        }

        public static Preference GetInstance()
        {
            if (_preference == null)
                lock (_lock)
                    if (_preference == null)
                        _preference = new Preference();

            return _preference;
        }

        public string GetPreference(string key)
        {
            if (key == _preference.key)
                return _preference.value;
            return null;
        }

        public void SetPreference(string key, string value)
        {
            if (key == _preference.key)
                _preference.value = value;
            if (_preference.key == null)
            {
                _preference.key = key;
                _preference.value = value;
            }
        }
    }
}