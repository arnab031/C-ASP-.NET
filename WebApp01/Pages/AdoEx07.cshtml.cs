using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp01.Pages
{
	public class AdoEx07Model : PageModel
    {
        string cs = string.Empty;
        string query = string.Empty;
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public AdoEx07Model()
        {
           cs = "server=localhost;Database=SalesDB;User=sa;Password=Arnab@123";
            cn = new SqlConnection(cs);
            cn.Open();
        }
        public void OnGet()
        {
            query = "spGetAllProducts";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            List<Product> Products = new List<Product>();
            while (dr.Read())
            {
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(dr[0]);
                p1.ProductName = dr[1].ToString();
                p1.Model = dr[2].ToString();
                p1.Price = Convert.ToInt32(dr[3]);
                Products.Add(p1);
            }
            cn.Dispose();
            dr.Close();
            ViewData["Products"] = Products;
        }
    }
}
