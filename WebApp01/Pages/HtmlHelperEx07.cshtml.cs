using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class HtmlHelperEx07Model : PageModel
    {
        public void OnGet()
        {
            ViewData["tot"] = 0;
            ViewData["avg"] = 0;
            ViewData["result"] = string.Empty;
            ViewData["grade"] = string.Empty;

        }
        public void OnPost(int m,int p,int c)
        {
            int tot = m + p + c;
            double avg = tot / 3.0;
            string result;
            string grade;

            ViewData["tot"] = tot;
            ViewData["avg"] = avg;
            if(m>=35 && p>=35 && c >= 35)
            {
                result = "PASS";
                if (avg >= 75) grade = "A1";
                else if (avg >= 60) grade = "A";
                else if (avg >= 50) grade = "B";
                else grade = "C";
            }
            else
            {
                result = "FAIL";
                grade = "NA";
            }
            ViewData["result"] = result;
            ViewData["grade"] = grade;
        }
    }
}
