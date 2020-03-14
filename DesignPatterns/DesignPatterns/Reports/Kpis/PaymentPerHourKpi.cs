using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public class PaymentPerHourKpi : Kpi
    {
        public PaymentPerHourKpi(IEnumerable<ClassInfo> classHours, DayOfWeek dayOfWeek) : base(classHours, dayOfWeek)
        {
        }

        protected override double KpiFunction(List<ClassInfo> filtered)
        {
            var result = filtered.Sum(ch => ch.paymentBdt) / filtered.Sum(ch => ch.durationHours);
            if (double.IsNaN(result))
                result = 0;

            return result;
        }
    }
}
