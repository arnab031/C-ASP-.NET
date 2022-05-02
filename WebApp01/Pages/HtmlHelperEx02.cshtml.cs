using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx02Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = string.Empty;
        }
        public void OnPost(string b1,string t1)
        {
            string msg = string.Empty;
            switch (b1)
            {
                case "hello":
                    msg = $"Hello {t1}";
                    break;
                case "length":
                    msg = $"Length of {t1} is {t1.Length}";
                    break;
                case "upper":
                    msg = $"UPPER of {t1} is {t1.ToUpper()}";
                    break;
                case "lower":
                    msg = $"Lower of {t1} is {t1.ToLower()}";
                    break;
            }
            ViewData["Message"] = msg;
        }
    }
}
