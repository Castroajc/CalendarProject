using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarDotNet.Model;

namespace CalendarDotNet.Persistence
{
    public class InitialData
    {
        public static List<Months> GetMonths()
        {
            List<Months> months = new List<Months>();

            //loop to creat all of the months
            for(int i = 0; i<12; i++)
            {
                Months tempMonth = new Months(i, 2019);
                months.Add(tempMonth);
            }

            return months;
        }

        public static List<Days> GetDays()
        {
            List<Days> days = new List<Days>
            {
                //hard coded values for the days table
                new Days(0, 1, "Clever Title", "Yo we eating pizza after class?", "3:00pm"),
                new Days(0, 2, "Moose", "sang", "2:00am")  //
            };


            return days;
        }
    }
}
