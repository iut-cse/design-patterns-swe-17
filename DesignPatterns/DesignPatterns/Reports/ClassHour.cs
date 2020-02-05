using System;

namespace DesignPatterns.Reports
{
    public class ClassHour
    {
        public readonly string department;
        public readonly DateTime date;
        public readonly double durationHours;
        public readonly double paymentBdt;

        public ClassHour(string department
            , DateTime date
            , double durationHours
            , double paymentBdt = 0)
        {
            this.department = department;
            this.date = date;
            this.durationHours = durationHours;
            this.paymentBdt = paymentBdt;
        }
    }
}