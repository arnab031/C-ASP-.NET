using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class PassingDataDemoModel : PageModel
    {
        public void OnGet()
        {
            ViewData["name"] = "Arnab";
            ViewData["city"] = "Vizag";
        }
    }
}
