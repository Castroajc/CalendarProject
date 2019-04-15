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
        public void UpdateEvent(int dayId, int monthId, string title, string description, string startTime)
        {
            foreach(Days day in daysList)
            {
                if(dayId == day.GetyDayId() && monthId == day.GetMonthId())
                {
                    day.SetTitle(title);
                    day.SetDescription(description);
                    day.SetStartTime(startTime);
                }
            }
        }
    }
}
