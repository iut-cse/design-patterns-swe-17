using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task3
{
    class Preference
    {
        

        private static Preference instance;
        IDictionary<string, string> preference = new Dictionary<string, string>();
        private static readonly object lockMethod = new object();

        private Preference()
        {
            // TODO: implement SingleTon
        }

        public static Preference getInstance()
        {
            if (instance == null)
            {
                lock (lockMethod)
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
}
