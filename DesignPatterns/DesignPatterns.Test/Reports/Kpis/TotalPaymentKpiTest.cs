using DesignPatterns.Reports.Kpis;
using System;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalPaymentKpiTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new TotalPaymentKpi();
            var actual = tch.Calculate(data, ci => ci.date.DayOfWeek == DayOfWeek.Monday && ci.department == "Physics");

            Assert.Equal(5200, actual);
        }
    }
}
