using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    public class Days
    {
        private int monthId;
        private int dayId;
        private string title;
        private string description;
        private string startTime;

        public Days(int monthId, int dayId, string title, string description, string startTime)
        {
            //Contsructor
            this.monthId = monthId;
            this.dayId = dayId;
            this.title = title;
            this.description = title;
            this.startTime = startTime;
        }

        //Getters
        public int GetMonthId()
        {
            return monthId;
        }
        public int GetyDayId()
        {
            return dayId;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetDescription()
        {
            return description;
        }
    }
}
