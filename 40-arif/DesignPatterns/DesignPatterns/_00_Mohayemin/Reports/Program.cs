using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<ClassHour>
            {
                new ClassHour("Physics", new DateTime(2020, 1, 20), 4),
                new ClassHour("Physics", new DateTime(2020, 1, 27), 5),
                new ClassHour("Chemistry", new DateTime(2020, 1, 21), 2),
                new ClassHour("Bangla", new DateTime(2020, 1, 22), 6),
                new ClassHour("English", new DateTime(2020, 1, 23), 6),
                new ClassHour("English", new DateTime(2020, 1, 16), 1),
            };
            ReportTable table = new ReportTable(data,1,0);
            StringBuilder sb = new StringBuilder();
            table.Render(sb,1);
            Console.WriteLine(sb);
        }
    }
}
