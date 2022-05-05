using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AdoDemoModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            string cs = "server=localhost;Database=EmployeeDB;User=sa;Password=Arnab@123";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                ViewData["Message"] = "Connection established successfully...";
            }
            catch(SqlException ex)
            {
                ViewData["Message"] = "DB Connection error " + ex.Message;
            }catch(Exception ex)
            {
                ViewData["Message"] = "Error " + ex.Message;
            }
            
        }
    }
}
