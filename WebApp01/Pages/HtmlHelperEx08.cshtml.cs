using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx08Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(string q1a1, string q2a1, string q3a1, string q4a1)
        {
            int count = 0;
            if (q1a1 == "Modi") ++count;
            if (q2a1 == "Joe Biden") ++count;
            if (q3a1 == "Boris Johnson") ++count;
            if (q4a1 == "Volodymyr Zelenskyy") ++count;

            ViewData["Message"] = $"Score is: {count}/4";
        }
    }
}
