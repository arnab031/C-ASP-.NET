using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace WebApp01.Pages
{
	public class SessionEx01Model : PageModel
    {
        public void OnGet()
        {
            if (HttpContext.Session.GetString("name") != null)
            {
                string name = HttpContext.Session.GetString("name");
                string city = HttpContext.Session.GetString("city");
                ViewData["name"] = name;
                ViewData["city"] = city;
            }
            else
            {
                ViewData["Message"] = "Session not exist or erased.....";
            }
        }
    }
}
