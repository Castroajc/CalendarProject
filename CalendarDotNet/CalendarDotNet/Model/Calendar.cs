using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    public class Calendar
    {
        //initialized variables
        private int day, month;

        //constructor
        public Calendar()
        {
        }
        //getters and setters
        public int GetDay()
        {
            return day;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }
    }
}
