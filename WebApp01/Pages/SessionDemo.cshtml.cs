using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace WebApp01.Pages
{
	public class SessionDemoModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(string name, string city)
        {
            //To Create Session
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetString("city", city);
            ViewData["Message"] = "Session Created Successfully...";
        }
    }
}
