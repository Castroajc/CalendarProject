using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalendarDotNet.Pages
{
    public class EditEventModel : PageModel
    {
        public String Message { get; set; }
        public void OnGet()
        {
            Message = "congrats you made it";
        }
    }
}