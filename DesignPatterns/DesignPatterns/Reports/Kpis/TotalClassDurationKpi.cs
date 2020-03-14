using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalClassDurationKpi : Kpi
    {
        public TotalClassDurationKpi(
            IEnumerable<ClassInfo> classHours, DayOfWeek dayOfWeek) : base(classHours, dayOfWeek)
        {
        }

        protected override double KpiFunction(List<ClassInfo> filtered)
        {
            return filtered.Sum(ch => ch.durationHours);
        }
    }
}
