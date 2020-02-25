using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public abstract class Kpi : IKpi
    {
        protected readonly DayOfWeek dayOfWeek;

        protected Kpi(DayOfWeek dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
        }

        public KpiResult Calculate(IEnumerable<ClassInfo> data)
        {
            var filtered = data.Where(ci => ci.date.DayOfWeek == dayOfWeek);
            var grouped = filtered.GroupBy(ci => ci.department);
            var mapped = GroupToDictionary(grouped);
            var result = new KpiResult(mapped);
            return result;
        }

        protected abstract IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped);
    }
}
