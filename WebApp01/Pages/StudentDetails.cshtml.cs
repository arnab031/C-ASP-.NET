using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class StudentDetailsModel : PageModel
    {
        public void OnGet()
        {
            string cs = "server=localhost;Database=CollegeDB;User=sa;Password=Arnab@123";
            try
            {
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                string query = "select * from tblStudents";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<StudentModel> list = new List<StudentModel>();
                while (dr.Read())
                {
                    StudentModel stu = new StudentModel();
                    stu.Id = Convert.ToInt32(dr[0]);
                    stu.SName = dr[1].ToString();
                    stu.age = Convert.ToInt32(dr[2]);
                    stu.course = dr[3].ToString();
                    list.Add(stu);
                }
                ViewData["Students"] = list;
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
