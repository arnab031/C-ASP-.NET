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
            if (HttpContext.Session.GetString("uname") != null)
            {
                string uname = HttpContext.Session.GetString("uname");
                ViewData["Message"] = $"Hello {uname}, Welcome to dashboard";
            }
            else
            {
                ViewData["Message"] = "Session doesn't exist";
            }
        }
    }
}
