using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class PaymentPerHour : Kpi
    {
        public PaymentPerHour(IEnumerable<ClassInfo> classHours
            , DayOfWeek dayOfWeek)
            : base(classHours, dayOfWeek)
        {
        }

        protected override IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped)
        {
            return grouped.ToDictionary(g => g.Key, g => g.Sum(ci => ci.paymentBdt) / g.Sum(ci => ci.durationHours));
        }

    }
}
