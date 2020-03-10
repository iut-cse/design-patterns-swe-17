using DesignPatterns.Reports;
using DesignPatterns.Test.Reports.Kpis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DesignPatterns.Test._Demos
{
    public class ReportDemo
    {
        [Fact]
        void Demo()
        {
            var data = TestData.CreateData().ToList();
            ReportTable table = new ReportTable(data, "left");
            StringBuilder sb = new StringBuilder();
            table.Render(sb);
            new OutputFile().Write(sb.ToString());
        }
    }
}
