using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatterns._00_Mohayemin.Reports
{
    public class ReportTableTest
    {
        private readonly ITestOutputHelper output;

        public ReportTableTest(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        void X()
        {
            var data = new List<ClassHour>
            {
                new ClassHour("Physics", new DateTime(2020, 1, 20), 4),
                new ClassHour("Physics", new DateTime(2020, 1, 27), 5),
                new ClassHour("Chemistry", new DateTime(2020, 1, 21), 2),
                new ClassHour("Math", new DateTime(2020, 1, 22), 6),
                new ClassHour("English", new DateTime(2020, 1, 23), 6),
                new ClassHour("English", new DateTime(2020, 1, 16), 1),
            };

            ReportTable table = new ReportTable(data);
            StringBuilder sb = new StringBuilder();
            table.Render(sb);
            output.WriteLine(sb.ToString());
        }
    }
}
