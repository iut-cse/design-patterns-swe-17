using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalClassDurationKpi : IKpi
    {
        private readonly IEnumerable<ClassInfo> classHours;
        private readonly DayOfWeek dayOfWeek;

        public TotalClassDurationKpi(IEnumerable<ClassInfo> classHours
            , DayOfWeek dayOfWeek)
        {
            this.classHours = classHours;
            this.dayOfWeek = dayOfWeek;
        }

        public IDictionary<string, double> Calculate()
        {
            var filtered = classHours.Where(ch => ch.date.DayOfWeek == dayOfWeek);
            var grouped = filtered.GroupBy(ch => ch.department);
            var mapped = grouped.ToDictionary(g => g.Key, g => g.Sum(ch => ch.durationHours));
            return mapped;
        }
    }
}
