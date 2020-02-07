using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Xunit;
using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalPaymentKpiTest
    {
        List<ClassInfo> data;
        public TotalPaymentKpiTest()
        {
            this.data = new List<ClassInfo>
            {
                new ClassInfo("Physics", new DateTime(2020, 1, 20), 4,1000), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 27), 5,450), // Monday
                new ClassInfo("Physics", new DateTime(2020, 1, 28), 5,5000), // Tuesday
                new ClassInfo("Chemistry", new DateTime(2020, 1, 21), 2,100), // Tuesday
                new ClassInfo("Math", new DateTime(2020, 1, 22), 6, 10), // Wednesday
                new ClassInfo("English", new DateTime(2020, 1, 23), 6, 6000), // Thursday
                new ClassInfo("English", new DateTime(2020, 1, 16), 1, 100), // Thursday
                new ClassInfo("Bangla", new DateTime(2020, 1, 13), 6, 2), // Monday
            };
        }

        [Fact]
        public void Monday()
        {
            var tch = new TotalPaymentKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(1450, output["Physics"]);
            Assert.Equal(2, output["Bangla"]);
        }
    }
}
