using System;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class ClassHour
    {
        public readonly string department;
        public readonly DateTime date;
        public readonly int durationHours;

        public ClassHour(string department
            , DateTime date
            , int duration)
        {
            this.department = department;
            this.date = date;
            this.durationHours = duration;
        }
    }
}
