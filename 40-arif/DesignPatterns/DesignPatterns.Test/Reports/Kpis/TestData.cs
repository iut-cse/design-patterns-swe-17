using DesignPatterns.Reports;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TestData
    {
        public static List<ClassInfo> CreateData()
        {
            return new List<ClassInfo>
            {
                new ClassInfo("Physics", new DateTime(2020, 1, 20), 4, 200), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 27), 5, 5000), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 28), 5, 400), // Tuesday
                new ClassInfo("Chemistry", new DateTime(2020, 1, 21), 2, 100), // Tuesday
                new ClassInfo("Math", new DateTime(2020, 1, 22), 6, 50), // Wednesday
                new ClassInfo("English", new DateTime(2020, 1, 23), 6, 700), // Thursday
                new ClassInfo("English", new DateTime(2020, 1, 16), 1, 10), // Thursday
                new ClassInfo("Bangla", new DateTime(2020, 1, 13), 6, 2100), // Monday
            };
        }
    }
}
