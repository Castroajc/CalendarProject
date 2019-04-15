using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarDotNet.Persistence;
using CalendarDotNet.Model;
using CalendarDotNet.Controller;
using Microsoft.AspNetCore.Http;

namespace CalendarDotNet.Pages
{
    public class IndexModel : PageModel
    {
        private FakeDatabase fake;
        public int MonthId { get; set; }
        public Months Months;
        public List<Days> daysList;

        public string Message { get; set; }
        public IndexModel()
        {
            Message = "You finally did it, idiot";
            MonthId = 0;
            fake = new FakeDatabase();
            daysList = fake.LoadEvent(MonthId);
            Months = new Months(0, 2019);
        }

        public void OnGet()
        {
            
            
            /*string title = HttpContext.Session.GetString("title");
            string description = HttpContext.Session.GetString("description");
            string startTime = HttpContext.Session.GetString("startTime");
            int dayId = (int) HttpContext.Session.GetInt32("dayId");
            monthId = (int)HttpContext.Session.GetInt32("monthId");
            fake.UpdateEvent(10, monthId, title, description, startTime); */
        }
        public void OnPost()
        {
           // HttpContext.Session.SetInt32("monthId", monthId);
            //string dayId = Request.Form["dayId"];
            //HttpContext.Session.SetInt32("dayId",System.Convert.ToInt32(dayId));
        }
    }
}