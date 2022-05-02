using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class PostbackEx01Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = string.Empty;
        }
        public void OnPost(string b1)
        {
            if (b1 == "hello")
            {
                ViewData["Message"] = "Hello, GM!";
            }else if (b1 == "date")
            {
                ViewData["Message"] = $"Date is: {DateTime.Now.ToLongDateString()}";
            }else if (b1 == "time")
            {
                ViewData["Message"] = $"Time is: {DateTime.Now.ToLongTimeString()}"; 
            }
        }
    }
}
