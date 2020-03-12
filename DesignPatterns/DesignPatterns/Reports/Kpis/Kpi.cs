
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Reports.Kpis
{
    public abstract class Kpi : IKpi
    {
        public double Calculate(List<ClassInfo> data, Predicate<ClassInfo> filter)
        {
            var filtered = data.FindAll(filter);
            return KpiFunction(filtered);
        }

        protected abstract double KpiFunction(List<ClassInfo> filtered);
    }
}