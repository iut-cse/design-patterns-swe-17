using DesignPatterns.Reports.Kpis;
using System;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentPerHourTest
    {

        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentPerHour(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal((5200.0/9), output["Physics"]);
            Assert.Equal((2100.0/6), output["Bangla"]);
        }

    }
}
