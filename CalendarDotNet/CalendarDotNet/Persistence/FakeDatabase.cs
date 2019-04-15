using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarDotNet.Model;

namespace CalendarDotNet.Persistence
{
    public class FakeDatabase : IDatabase
    {
        private List<Days> daysList;
        private List<Months> monthsList;
        public FakeDatabase()
        {
            daysList = new List<Days>();
            monthsList = new List<Months>();

            daysList.AddRange(InitialData.GetDays());
            monthsList.AddRange(InitialData.GetMonths());
        }
        //will add the event into the database
        public List<Days> AddEvent(int monthId, int dayId, string title, string description, string startTime)
        {
            Days tempDay = new Days(monthId, dayId, title, description, startTime);
            daysList.Add(tempDay);
            return daysList;
        }

        public List<Days> LoadEvent(int monthId)
        {
            List<Days> listOfThisMonth = new List<Days>();
            foreach (Days day in daysList)
            {
                if(day.GetMonthId() == monthId)
                {
                    listOfThisMonth.Add(day);
                }

            }
            return listOfThisMonth;
        }
    }
}
