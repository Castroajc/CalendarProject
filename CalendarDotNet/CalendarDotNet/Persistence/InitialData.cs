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
            int daysMax = 31;
            List<Days> days = new List<Days>();
            for (int i = 0; i< 12; i++) {
                daysMax = DateTime.DaysInMonth(2019, i + 1);
                for (int j = 1; j <= daysMax; j++) {
                    if (j == 1) {
                        days.Add(new Days(i, 1, "Clever Title", "Yo we eating pizza after class?", "3:00pm"));
                    }
                    else if(j == 2)
                    {
                        days.Add(new Days(i, 2, "Moose", "sang", "2:00am"));
                    }
                    else
                    {
                        days.Add(new Days(i, j, "", "", ""));
                    }
                }
            }

            return days;
        }
    }
}
