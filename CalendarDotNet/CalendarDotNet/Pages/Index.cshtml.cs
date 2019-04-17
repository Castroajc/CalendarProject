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
            //intializes the variables that need to be set before the get method is called
            MonthId = 0;
            fake = new FakeDatabase();
            daysList = fake.LoadEvent(MonthId);
            Months = new Months(0, 2019);
        }

        public void OnGet()
        {
            //Message = "Get was called";   used to ensure that the get is called

            //grabs any items in the session with this specific id name
            string title = HttpContext.Session.GetString("title");
            string description = HttpContext.Session.GetString("description");
            string startTime = HttpContext.Session.GetString("startTime");

            fake.UpdateEvent(10, MonthId, title, description, startTime); 
        }
        public void OnPost()
        {
            //Message = "Post was called"; //used to ensure the post is called
            HttpContext.Session.SetInt32("monthId", MonthId);
            string dayId = Request.Form["dayId"];
            HttpContext.Session.SetInt32("dayId",System.Convert.ToInt32(dayId));
        }
    }
}