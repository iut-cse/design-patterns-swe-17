using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Reports.Kpis
{
    public class TotalPaymentKpi : Kpi
    {
        private readonly IEnumerable<ClassInfo> paymentBDT;
        private readonly DayOfWeek dayOfWeek;

        public TotalPaymentKpi(IEnumerable<ClassInfo> paymentBDT, DayOfWeek dayOfWeek)
            : base(paymentBDT, dayOfWeek)
        {

        }

        protected override IDictionary<string, double> GroupToDictionary(IEnumerable<IGrouping<string, ClassInfo>> grouped)
        {
            return grouped.ToDictionary(g => g.Key, g => g.Sum(ch => ch.paymentBdt));
        }
    }
}
