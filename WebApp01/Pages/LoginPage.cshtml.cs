using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
    class User
    {
        public string UName { get; set; }
        public string Pwd { get; set; }
    }
	public class LoginPageModel : PageModel
    {
        List<User> users = new List<User>();
        public LoginPageModel()
        {
            users = new List<User>()
            {
                new User{Pwd="raj",UName="raj"},
                new User{Pwd="arnab",UName="arnab"},
                new User{Pwd="ashu",UName="ashu"}
            };
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(string uname, string pwd,bool cb)
        {
            if(users.Exists(x=>x.UName==uname && x.Pwd==pwd))
            {
                HttpContext.Session.SetString("uname", uname);
                if (cb==true)
                {
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = DateTime.Now.AddDays(7);

                    Response.Cookies.Append("uname", uname, cookieOptions);
                }
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
