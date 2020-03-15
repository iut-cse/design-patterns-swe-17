using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalClassDurationKpi : Kpi
    {
        protected override double KpiFunction(List<ClassInfo> filtered)
        {
            return filtered.Sum(ch => ch.durationHours);
        }
    }
}
