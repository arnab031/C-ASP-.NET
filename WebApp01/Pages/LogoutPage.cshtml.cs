using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class LogoutPageModel : PageModel
    {
        public void OnGet()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                string uname = HttpContext.Session.GetString("uname");
                ViewData["Message"] = $"{uname} logged out successfully";
                HttpContext.Session.Clear();

                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(-1);

                Response.Cookies.Append("uname", uname, cookieOptions);
            }
            else
            {
                ViewData["Message"] = "No session active to logout....";
            }
            
        }
    }
}
