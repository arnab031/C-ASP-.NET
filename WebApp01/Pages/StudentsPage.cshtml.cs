using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace WebApp01.Pages
{
	public class StudentsPageModelModel : PageModel
    {
        StudentContext context = null;
        public StudentsPageModelModel()
        {
            //context = new StudentContext(new DotNetStudentRepository());
            //context = new StudentContext(new JavaStudentRepository());
        }
        public void OnGet()
        {
            //ViewData["Students"] = context.GetAllStudents();
            //ViewData["Category"] = context.GetCategory();
            ViewData["Students"] = new List<StudentModel1>();
            ViewData["Category"] = "";
        }
        public void OnPost(string b1)
        {

            Debug.WriteLine
                ("Value of b1======>", b1);
            if (b1 == "Java")
            {
                context = new StudentContext(new JavaStudentRepository());
            }
            else
            {
                context = new StudentContext(new DotNetStudentRepository());
            }
            ViewData["Students"] = context.GetAllStudents();
            Console.WriteLine("Get all students data====>", context.GetAllStudents());
            ViewData["Category"] = context.GetCategory();
        }
    }
}
