using System;
using System.Collections.Generic;

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

        public abstract IDictionary<string, double> Calculate();
    }
}
