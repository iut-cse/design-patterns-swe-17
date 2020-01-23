using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class ReportTable
    {
        private readonly IList<ClassHourModel> classHours;

        public ReportTable(IList<ClassHourModel> classHours)
        {
            this.classHours = classHours;
        }

        public string Render()
        {
            return null;
        }
    }
}
