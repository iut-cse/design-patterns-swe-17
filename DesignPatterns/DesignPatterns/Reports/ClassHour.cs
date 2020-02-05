using System;

namespace DesignPatterns.Reports
{
    public class ClassHour
    {
        public readonly string department;
        public readonly DateTime date;
        public readonly double durationHours;

        public ClassHour(string department
            , DateTime date
            , double durationHours)
        {
            this.department = department;
            this.date = date;
            this.durationHours = durationHours;
        }
    }
}