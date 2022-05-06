using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AdoEx06Model : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(string b1)
        {
            ViewData["Message"] = b1;
            if(b1== "employee")
            {
                return RedirectToPage("EmployeeDetails");
            }else if (b1 == "student")
            {
                return RedirectToPage("StudentDetails");
            }
            return null;
        }
    }
}
