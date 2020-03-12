using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Reports.Kpis
{
    public class PaymentPerHourKpi : Kpi
    {
        public PaymentPerHourKpi(IEnumerable<ClassInfo> classHours
            , DayOfWeek dayOfWeek)
            : base(classHours, dayOfWeek)
        {

        }

        protected override IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped)
        {
            return grouped.ToDictionary(g => g.Key, g => g.Sum(ch => ch.paymentBdt / g.Sum(ch => ch.durationHours)));
        }
    }
}
