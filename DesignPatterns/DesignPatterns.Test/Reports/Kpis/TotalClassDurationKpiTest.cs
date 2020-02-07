using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalClassDurationKpiTest
    {
        List<ClassInfo> data;
        public TotalClassDurationKpiTest()
        {
            this.data = new List<ClassInfo>
            {
                new ClassInfo("Physics", new DateTime(2020, 1, 20), 4), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 27), 5), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 28), 5), // Tuesday
                new ClassInfo("Chemistry", new DateTime(2020, 1, 21), 2), // Tuesday
                new ClassInfo("Math", new DateTime(2020, 1, 22), 6), // Wednesday
                new ClassInfo("English", new DateTime(2020, 1, 23), 6), // Thursday
                new ClassInfo("English", new DateTime(2020, 1, 16), 1), // Thursday
                new ClassInfo("Bangla", new DateTime(2020, 1, 13), 6), // Monday
            };
        }

        [Fact]
        public void Monday()
        {
            var tch = new TotalClassDurationKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(9, output["Physics"]);
            Assert.Equal(6, output["Bangla"]);
        }

        [Fact]
        public void Tuesday()
        {

            IKpi kpi = new TotalClassDurationKpi(data, DayOfWeek.Tuesday);
            var output = kpi.Calculate();

            Assert.Equal(5, output["Physics"]);
            Assert.Equal(2, output["Chemistry"]);
        }
    }
}
