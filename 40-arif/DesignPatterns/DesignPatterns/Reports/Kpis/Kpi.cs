using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public abstract class Kpi : IKpi
    {
        protected readonly IEnumerable<ClassInfo> classHours;
        protected readonly DayOfWeek dayOfWeek;

        protected Kpi(IEnumerable<ClassInfo> classHours
            , DayOfWeek dayOfWeek)
        {
            this.classHours = classHours;
            this.dayOfWeek = dayOfWeek;
        }

        public KpiResult Calculate()
        {
            var filtered = classHours.Where(ci => ci.date.DayOfWeek == dayOfWeek);
            var grouped = filtered.GroupBy(ci => ci.department);
            var mapped = GroupToDictionary(grouped);
            var result = new KpiResult(mapped);
            return result;
        }

        protected abstract IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped);
    }
}
