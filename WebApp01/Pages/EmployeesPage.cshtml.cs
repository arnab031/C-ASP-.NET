using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class EmployeesPageModel : PageModel
    {
        IEmployeeRepository _repositories;
        public EmployeesPageModel(IEmployeeRepository repositories)
        {
            _repositories = repositories;
        }
        public void OnGet()
        {
            ViewData["Employees"] = _repositories.GetEmployees();
        }
        //public void OnPost(string b1)
        //{
        //    if (b1 == "HR")
        //    {
        //        //List<EmpModel> employees = _repositories.First(x => x.Category() == "HR");
        //        ViewData["Employees"] = _repositories.SingleOrDefault(x => x.Category() == "HR");
                
        //    }
        //    else if (b1 == "Technical")
        //    {
        //        ViewData["Employees"] = _repositories.SingleOrDefault(x => x.Category() == "Technical");
        //    }
        //}
    }
}
