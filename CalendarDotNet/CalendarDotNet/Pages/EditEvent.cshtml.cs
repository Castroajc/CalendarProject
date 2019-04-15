using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarDotNet.Model;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace CalendarDotNet.Pages
{
    public class EditEventModel : PageModel
    {
        static string SubstitutionMethod(HttpContext context)
        {
            return "My Content";
        }
        public void OnGet()
        {
            Console.WriteLine("this is some more text");
        }
        public void OnPost()
        {
            string title = Request.Form["title"];   //grabs the data from the html page
            Console.WriteLine("this is some text " + title);
            string description = Request.Form["description"];
            string startTime = Request.Form["time"];
            //for when there is nothing to put inside yet
            if(title == null)
            {
                title = "";
            }
            if(description== null)
            {
                description = "";
            }
            if(startTime == null)
            {
                startTime = "";
            }



            HttpContext.Session.SetString("title", title);  //puts the data into the session
            HttpContext.Session.SetString("description", description);
            HttpContext.Session.SetString("time", startTime);
        }
    }
}