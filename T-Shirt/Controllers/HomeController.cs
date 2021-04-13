using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T_Shirt.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace T_Shirt.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
       
        private readonly IConfiguration configuration;
        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index(Account acc)
        {


            return View();
        }
        public IActionResult About(Account acc)
        {


            return View();
        }
        public IActionResult amit()
        {


            return View();
        }

        void connectionString()
        {
                con.ConnectionString = "Server=DESKTOP-Q6GR1B2\\AMITSQL; Database=tshirt; User ID=sa; Password=123456";
        }
        public IActionResult Signin(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from registration where email='" + acc.email + "'and  password1='" + acc.password + "'";
            string em = acc.email;
            ////Console.WriteLine(em);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                
                {
                    con.Close();
                    return View("Index");
                   // return RedirectToAction("Signup");
                }
                
            }
            else
            {
                con.Close();
                return View();
            }


            return View();
        }
        public IActionResult Signup(string userid, string email, string password1, string password2)
        {
            try
            {
                string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand comm = new SqlCommand("insert into registration values('" + userid.ToString() + "','" + email.ToString() + "','" + password1.ToString() + "','" + password2.ToString() + "')", connection);
                comm.ExecuteNonQuery();
                connection.Close();
               
            }
            catch (Exception e)
            {

            }
            return View();
        }


        public IActionResult contact(string name,string email, string subject, string message)
        {
            try
            {
                string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                SqlCommand comm = new SqlCommand("insert into contactDetails values('" + name.ToString() + "','" + email.ToString() + "','" + subject.ToString() + "','" + message.ToString() + "')", connection);
                comm.ExecuteNonQuery();
                connection.Close();
                
            }catch(Exception e)
            {
               
            }
            return View();
        }
        public IActionResult cart()
        {
            string dbcon = configuration.GetConnectionString("DefaultConnectionString");
            SqlConnection connection = new SqlConnection(dbcon);
            connection.Open();
            SqlCommand command = new SqlCommand("Select count(*) from contactDetails",connection);
            var count = (int)command.ExecuteScalar();
            ViewData["td"] = count;
            connection.Close();
            return View();
        }
        public IActionResult showContact()
        {
            List<Models.contact> list = new List<Models.contact>();
            try
            {
                string dbcon = configuration.GetConnectionString("DefaultConnectionString");
                SqlConnection connection = new SqlConnection(dbcon);
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand("Select * from contactDetails", connection);
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    var c = new Models.contact();
                    c.name = row["name"].ToString();
                    c.email = row["email"].ToString();
                    c.subject = row["subject"].ToString();
                    c.message = row["message"].ToString();
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

        public IActionResult display()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult rough(string name, string age)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["projectDatabase"].ConnectionString;
            SqlConnection connection = new SqlConnection(myConnectionString);
            connection.Open();
            SqlCommand comm = new SqlCommand("insert into rough values ( '" + name.ToString() + "','" + age.ToString() + "')", connection);
            comm.ExecuteNonQuery();
            connection.Close();

            return View();
        }
    }
}
