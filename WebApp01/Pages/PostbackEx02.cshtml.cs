using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class PostbackEx02Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = string.Empty;
        }
        public void OnPost(string t1)
        {
            ViewData["Message"] = $"Hello {t1}";
        }
    }
}
