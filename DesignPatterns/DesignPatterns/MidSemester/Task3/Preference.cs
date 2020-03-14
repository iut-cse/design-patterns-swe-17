using System;
using System.Collections.Generic;
using System.Text;
namespace DesignPatterns.MidSemester.Task3
{
    public class Preference
    {
        private static Preference instance;
        private static readonly object threadlock = new object();
        public string key = null;
        public string val = null;

        private Preference() { }
        public static Preference GetInstance()
        {
            if (instance == null)
            {
                lock (threadlock)
                {
                    if (instance == null)
                        instance = new Preference();
                }
            }
            return instance;
        }

        public void SetPreference(string key, string value)
        {
            if (key == instance.key)
            {
                instance.val = value;
            }

            else if (instance.key == null)
            {
                instance.key = key;
                instance.val = value;
            }
        }

        public string GetPreference(string key)
        {
            if (key == instance.key)
                return instance.val;

            return null;
        }

    }
}