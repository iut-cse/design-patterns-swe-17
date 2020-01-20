using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Sjson : perser
    {
        public string getData(int index)
        {
           return "airline: Aer Lingus/navail_seat_km_per_week: 320906734/n incidents: 2";
        }

        public int getItem()
        {
            return 3;
        }
    }
}
