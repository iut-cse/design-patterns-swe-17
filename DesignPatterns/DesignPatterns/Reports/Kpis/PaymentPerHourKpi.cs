using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Reports.Kpis
{
    class PaymentPerHourKpi:Kpi
    {
       
         public PaymentPerHourKpi(IEnumerable<ClassInfo> classHours , DayOfWeek dayOfWeek)
            :base (classHours, dayOfWeek)
        {
           
        }
        public KpiResult Calculate(){
        }
     
    }



}
