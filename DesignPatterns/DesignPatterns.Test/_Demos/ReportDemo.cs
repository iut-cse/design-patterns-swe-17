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
            /*{
                new ClassInfo("Physics", new DateTime(2020, 1, 20), 4),
                new ClassInfo("Physics", new DateTime(2020, 1, 27), 5),
                new ClassInfo("Chemistry", new DateTime(2020, 1, 21), 2),
                new ClassInfo("Math", new DateTime(2020, 1, 22), 6),
                new ClassInfo("English", new DateTime(2020, 1, 23), 6),
                new ClassInfo("English", new DateTime(2020, 1, 16), 1),
            };*/
            ReportTable table = new ReportTable(data, "left");
            StringBuilder sb = new StringBuilder();
            table.Render(sb);
            new OutputFile().Write(sb.ToString());
        }
    }
}
