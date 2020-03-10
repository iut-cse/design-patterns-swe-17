using System;
using System.Collections.Generic;

namespace DesignPatterns.Reports.Kpis
{
    public interface IKpi
    {
        double Calculate(List<ClassInfo> data, Predicate<ClassInfo> filter);
    }
}
