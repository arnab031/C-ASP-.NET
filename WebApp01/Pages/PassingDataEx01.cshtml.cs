using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class PassingDataEx01Model : PageModel
    {
        public void OnGet()
        {
            string[] cakes = new string[] { "Pine apple", "Back Forest", "White Forest", "Chocolate" };
            ViewData["cakes"] = cakes;

            List<string> sweets = new List<string> { "Laddu", "Jilebi", "Khaja" };
            ViewData["sweets"] = sweets;
        }
    }
}
