using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Xunit;
using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentPerHourKpiTest
    {
        List<ClassInfo> data;
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentPerHourKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();
            
            Assert.Equal(577.7777777777777, output["Physics"]);
            Assert.Equal(350, output["Bangla"]);
        }
    }
}
