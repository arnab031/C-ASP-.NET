using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx09Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(string language)
        {
            ViewData["Message"] = $"Selected language {language}";
        }
    }
}
