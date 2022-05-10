using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class LoginPageModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(string uname, string pwd)
        {
            if(uname=="Kiran" && pwd == "Kumar")
            {
                HttpContext.Session.SetString("uname", uname);
                return Redirect("/dashboard");
            }
            else
            {
                ViewData["Message"] = "Invalid input credentials...";
            }
            return null;
        }
    }
}
