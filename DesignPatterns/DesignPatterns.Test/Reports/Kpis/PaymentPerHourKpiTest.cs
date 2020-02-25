using System;
using DesignPatterns.Reports.Kpis;
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

            Assert.Equal(5200.0/9, output["Physics"], 4);
            Assert.Equal(2100.0/6, output["Bangla"], 4);
        }
    }
}