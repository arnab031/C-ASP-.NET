using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class EmployeeDetailsModel : PageModel
    {
        public void OnGet()
        {
            
            string cs = "server=localhost;Database=EmployeeDB;User=sa;Password=Arnab@123";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string query = "select * from tblEmployees";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<EmpModel> list = new List<EmpModel>();
                while (dr.Read())
                {
                    EmpModel emp = new EmpModel();
                    emp.Id = Convert.ToInt32(dr[0]);
                    emp.EName = dr[1].ToString();
                    emp.Job = dr[2].ToString();
                    emp.Salary = Convert.ToInt32(dr[3]);
                    list.Add(emp);

                }
                ViewData["Employees"] = list;
                cn.Dispose();
                dr.Close();
            }
            catch (SqlException ex)
            {
                ViewData["Message"] = "DB Connection error " + ex.Message;
            }
            catch (Exception ex)
            {
                ViewData["Message"] = "Error " + ex.Message;
            }
            
        }
        public void OnPost()
        {
            
        }
    }
}
