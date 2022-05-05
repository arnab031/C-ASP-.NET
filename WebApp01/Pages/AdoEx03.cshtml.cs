using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AdoEx03Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int id, string ename, string job, int salary)
        {
            string cs = "server=localhost;Database=EmployeeDB;User=sa;Password=Arnab@123";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string query = "insert into tblEmployees (id,ename,job,salary) values(@id,@ename,@job,@salary)";
                SqlCommand cmd = new SqlCommand(query, cn);
                
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.ExecuteNonQuery();
                ViewData["Message"] = "Row added successfully...";
                cn.Dispose();
                
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
    }
}
