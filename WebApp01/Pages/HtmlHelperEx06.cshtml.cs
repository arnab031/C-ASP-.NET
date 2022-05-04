using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx06Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = string.Empty;
        }
        public void OnPost(string t1, bool terms)
        {
            if (terms)
            {
                ViewData["Message"] = $"Thank you {t1} for accepting terms...";
            }
            else
            {
                ViewData["Message"] = $"{t1} must read and accepting terms before submission";
            }
        }
    }
}
