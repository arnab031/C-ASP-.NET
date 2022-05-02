using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx04Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = string.Empty;
        }
        public void OnPost(int a,int b,string b1)
        {
            string msg = string.Empty;
            int c = 0;
            switch (b1)
            {
                case "add":
                    c = a + b;
                    break;
                case "sub":
                    c = a - b;
                    break;
                case "big":
                    c = (a > b) ? a : b;
                    break;
                case "small":
                    c = (a < b) ? a : b;
                    break;
            }
            ViewData["Message"] = $"{b1} of {a} and {b} is {c}";
        }
           
        
    }
}
