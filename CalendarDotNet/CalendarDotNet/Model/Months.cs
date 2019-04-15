using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    public class Months
    {
        private int monthId;
        private int year;
        private string[] MonthName = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

        public Months(int monthId, int year)
        {
            this.monthId = monthId;
            this.year = year;
        }

        public int GetMonthId()
        {
            return monthId;
        }

        public int GetYear()
        {
            return year;
        }
        public string GetMonthName(int monthIndex)
        {
            return MonthName[monthIndex];
        }
    }
}
