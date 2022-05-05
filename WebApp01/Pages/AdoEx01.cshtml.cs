using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AdoEx01Model : PageModel
    {
        public void OnGet()
        {
            
        }
        public void OnPost(int id)
        {
            string cs = "server=localhost;Database=EmployeeDB;User=sa;Password=Arnab@123";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string query = "select * from tblEmployees where id=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.Read())
                {
                    ViewData["ename"] = dr[1];
                    ViewData["job"] = dr[2];
                    ViewData["salary"] = dr[3];

                }
                
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
    }
}
