using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalClassDurationKpi :Kpi
    {
        private readonly IEnumerable<ClassInfo> classHours;
        private readonly DayOfWeek dayOfWeek;

        public TotalClassDurationKpi(IEnumerable<ClassInfo> classHours
            , DayOfWeek dayOfWeek)
            :base(classHours,dayOfWeek)
        {
            
        }

        protected override IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped)
        {
            return grouped.ToDictionary(g => g.Key, g => g.Sum(ch => ch.durationHours));
        }
    }
}
