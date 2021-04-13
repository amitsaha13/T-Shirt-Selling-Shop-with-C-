using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Shirt.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Web;



namespace T_Shirt.Controllers
{
    public class AdminPanelController : Controller
    {
        SqlCommand command;
        private readonly IConfiguration configuration;
        public AdminPanelController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult displayProduct(string userid, string email, string password1, string password2)
        {
            try
            {
                string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand comm = new SqlCommand("insert into registration values('" + userid.ToString() + "','" + email.ToString() + "','" + password1.ToString() + "','" + password2.ToString() + "')", connection);
                comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            return View();
        }*/
        public IActionResult isplayProduct(string id, string size, string quantity, string price)
        {
            try
            {
                string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand comm = new SqlCommand("insert into cart values('" + id.ToString() + "','" + size.ToString() + "','" + quantity.ToString() + "','" + price.ToString() + "')", connection);
                comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            return View();
        }
        /*  public IActionResult displayProduct(string id, string size, string quantity, string price)
          {
              try
              {
                  string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                  SqlConnection connection = new SqlConnection(connectionstring);
                  connection.Open();
                  SqlCommand comm = new SqlCommand("insert into cart values('" + id.ToString() + "','" + size.ToString() + "','" + quantity.ToString() + "','" + price.ToString() + "' )", connection);
                  comm.ExecuteNonQuery();

              }
              catch (Exception e)
              {

              }
              return View();
          }*/
        public IActionResult viewProduct()
        {
            List<Models.showProduct> list = new List<Models.showProduct>();
            try
            {
                string dbcon = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(dbcon);
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand("select productdetail.productname,discount,image,price ,productdetail.productid from productdetail join products on productdetail.productid = products.productid", connection);
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    var c = new Models.showProduct();
                    c.productName = row["productname"].ToString();
                    c.discount = row["discount"].ToString();
                    c.image = row["image"].ToString();
                    c.price = row["price"].ToString();
                    list.Add(c);
                }
                connection.Close();
                return View(list);

            }

            catch (Exception e)
            {
                return View();
            }

        }
        [HttpPost]
         public IActionResult InsertProduct(addProduct add   )
         {
             try
             {
                 string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                 SqlConnection connection = new SqlConnection(connectionstring);
                 connection.Open();
                 string sql = "insert into productDetails(catagory, subcatagory, productid, productname, productdetails, color, quantity, discount, price, image) values(@catagory,@subcatagory,@productid,@productname,@productdetails,@color,@quantity,@discount,@price,@image) ";
                 SqlCommand com = new SqlCommand(sql, connection);
                 com.Parameters.AddWithValue("@catagory",add.catagory);
                 com.Parameters.AddWithValue("@subcatagory", add.subcatagory);
                 com.Parameters.AddWithValue("@productid", add.productid);
                 com.Parameters.AddWithValue("@productname", add.productname);
                 com.Parameters.AddWithValue("@productdetails", add.productdetails);
                 com.Parameters.AddWithValue("@color", add.color);
                 com.Parameters.AddWithValue("@quantity", add.quantity);
                 com.Parameters.AddWithValue("@discount", add.discount);
                 com.Parameters.AddWithValue("@price", add.price);
                // com.Parameters.AddWithValue("@image", add.catagory);
              /*  if(file != null && file.ContentLength>0 )
                 {
                     string filename = Path.GetFileName(file.FileName);

                     //string imgpath = Path.Combine(Microsoft.SqlServer.Server("~/productImage/"),filename);
                 }*/
                 com.ExecuteNonQuery();

                 connection.Close();

             }
             catch (Exception e)
             {

             }


             return View();
         }

        public IActionResult Order()
        {
            
                string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand comm = new SqlCommand("select sum(price) from cart", connection);
                var bill = (int)comm.ExecuteScalar();
                ViewData["TotalBill"]= bill;
                connection.Close();

           
                return View();
        }



   
    }

   
}