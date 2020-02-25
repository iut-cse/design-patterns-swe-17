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
            var tch = new PaymentPerHourKpi();
            var actual = tch.Calculate(data, ci => ci.date.DayOfWeek == DayOfWeek.Monday && ci.department == "Physics");
            Assert.Equal(5200.0/9, actual, 4);
        }
    }
}