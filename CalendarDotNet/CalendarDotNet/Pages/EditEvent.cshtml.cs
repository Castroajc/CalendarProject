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
        public string Message { set; get; }
        static string SubstitutionMethod(HttpContext context)
        {
            return "My Content";
        }

        public void OnPost()
        {
            //Message = "Post Used";
            //this website actually pulls the OnPost first instead of the OnGet
            //Putting the OnPost first helps me remember that
        }
        public void OnGet()
        {
            Message = "Get used";
            Console.WriteLine("this is some more text");
            
            /* session is not able to grab the correct information, it is disabled just to keep the website running
            string title = (string) Request.Form["title"];   //grabs the data from the html page
            string description = Request.Form["description"];
            string startTime = Request.Form["time"];

            Console.WriteLine("this is some text " + title);

            if (title == null)
            {
                title = "";
            }
            if (description == null)
            {
                description = "";
            }
            if (startTime == null)
            {
                startTime = "";
            }

            HttpContext.Session.SetString("title", title);  //puts the data into the session
            HttpContext.Session.SetString("description", description);
            HttpContext.Session.SetString("time", startTime); */
        }
        
    }
}