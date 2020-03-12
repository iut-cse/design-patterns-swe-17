using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalClassDurationKpiTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new TotalClassDurationKpi();
            var actual = tch.Calculate(data, ci => ci.date.DayOfWeek == DayOfWeek.Monday && ci.department == "Physics");

            Assert.Equal(9, actual);
        }
    }
}