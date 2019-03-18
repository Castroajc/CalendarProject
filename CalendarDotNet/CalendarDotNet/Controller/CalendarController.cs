using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarDotNet.Model;

namespace CalendarDotNet.Controller
{
    public class CalendarController
    {
        private Calendar model;

        //sets the model variable to the model about to be used
        public void SetModel (Calendar model)
        {
            this.model = model;
        }

        //sets the calendar whenever the webpage first starts up
        public void StartCalendar()
        {
            model.SetDay(1);
            model.SetMonth(1);
        }

        //Called when the user clicks the previous month icon
        public void ChangeToPreviousMonth()
        {
            //set
            int month = model.GetMonth();

            if(month == 1)
            {
                model.SetMonth(12);
            }
            else
            {
                model.SetMonth(month - 1);
            }
        }

        //Called when the user clicks the next month icon
        public void ChangeToNextMonth()
        {
            
        }

    }
}
