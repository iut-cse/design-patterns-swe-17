using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalPaymentKpi
    {
        private readonly IEnumerable<ClassInfo> paymentBDT;
        private readonly DayOfWeek dayOfWeek;

        public TotalPaymentKpi(IEnumerable<ClassInfo> paymentBDT , DayOfWeek dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
            this.paymentBDT = paymentBDT;
        }

        public IDictionary<string, double> Calculate()
        {
            var filtered = paymentBDT.Where(ch => ch.date.DayOfWeek == dayOfWeek);
            var grouped = filtered.GroupBy(ch => ch.department);
            var mapped = grouped.ToDictionary(g => g.Key, g => g.Sum(ch => ch.paymentBdt));
            return mapped;
        }

    }
}
