using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AddEx08Model : PageModel
    {
        string cs = string.Empty;
        string query = string.Empty;
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public AddEx08Model()
        {
            cs = "server=localhost;Database=SalesDB;User=sa;Password=Arnab@123";
            cn = new SqlConnection(cs);
            cn.Open();
        }
        public void OnGet()
        {
            ViewData["p1"] = new Product();
        }
        public void OnPost(string b1,int id,string pname,string model,int price)
        {
            Product p1 = new Product();
            switch (b1)
            {
                case "search":
                    query = "spGetProductById";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        p1.Id = Convert.ToInt32(dr[0]);
                        p1.ProductName = dr[1].ToString();
                        p1.Model = dr[2].ToString();
                        p1.Price = Convert.ToInt32(dr[3]);
                    }
                    //Console.WriteLine(p1.ProductName);
                    cmd.Dispose();
                    dr.Close();
                    
                    break;
                case "create":
                    query = "spAddProduct";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@productName", pname);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                    ViewData["Message"] = "Row added succesfully";
                    break;
                default:
                    break;
                
            }
            ViewData["p1"] = p1;
          
        }
    }
}
