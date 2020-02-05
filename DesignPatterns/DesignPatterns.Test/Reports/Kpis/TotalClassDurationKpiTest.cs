using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalClassDurationKpiTest
    {
        List<ClassHour> data;
        public TotalClassDurationKpiTest()
        {
            this.data = new List<ClassHour>
            {
                new ClassHour("Physics", new DateTime(2020, 1, 20), 4), // Monday
                new ClassHour("Physics", new DateTime(2020, 1, 27), 5), // Monday
                new ClassHour("Physics", new DateTime(2020, 1, 28), 5), // Tuesday
                new ClassHour("Chemistry", new DateTime(2020, 1, 21), 2), // Tuesday
                new ClassHour("Math", new DateTime(2020, 1, 22), 6), // Wednesday
                new ClassHour("English", new DateTime(2020, 1, 23), 6), // Thursday
                new ClassHour("English", new DateTime(2020, 1, 16), 1), // Thursday
                new ClassHour("Bangla", new DateTime(2020, 1, 13), 6), // Monday
            };
        }

        [Fact]
        public void DoTest()
        {
            var tch = new TotalClassDurationKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(9, output["Physics"]);
            Assert.Equal(6, output["Bangla"]);
        }
    }
}
