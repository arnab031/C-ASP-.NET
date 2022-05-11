using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            string uname;
            if (HttpContext.Session.GetString("uname") != null)
            {
                uname = HttpContext.Session.GetString("uname");
                ViewData["Message"] = $"Hello {uname}, Welcome to dashboard state maintained using Session...";
            }
            else if (Request.Cookies["uname"] != null)
            {
                uname = Request.Cookies["uname"];
                ViewData["Message"] = $"Hello {uname}, Welcome to dashboard state maintained using Cookies...";
                //When session loose its state and logged using cookie, create session again
                HttpContext.Session.SetString("uname", uname);
            }
            else
            {
                ViewData["Message"] = "Session doesn't exist";
            }
        }
    }
}
