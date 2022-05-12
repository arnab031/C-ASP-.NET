using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class StudentsPageModelModel : PageModel
    {
        StudentContext context = null;
        public StudentsPageModelModel()
        {
            //context = new StudentContext(new DotNetStudentRepository());
            context = new StudentContext(new JavaStudentRepository());
        }
        public void OnGet()
        {
            ViewData["Students"] = context.GetAllStudents();
            ViewData["Category"] = context.GetCategory();
        }
    }
}
