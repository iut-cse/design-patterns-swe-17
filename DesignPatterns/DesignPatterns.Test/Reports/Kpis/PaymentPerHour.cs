using DesignPatterns.Reports.Kpis;
using System;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentPerHour
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new TotalPaymentKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(5200, output["Physics"]);
            Assert.Equal(2100, output["Bangla"]);
        }

    }
}
