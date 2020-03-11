using DesignPatterns.Reports.Kpis;
using System;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentPerHourKpiTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentPerHourKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(577.7777777777778, output["Physics"]);
            Assert.Equal(350, output["Bangla"]);
        }
    }
}
