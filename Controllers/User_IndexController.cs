using NEW_E_COMMERCE_WEB_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class User_IndexController : Controller
    {
        // GET: User_Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult User_Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_New_Visitors(New_visitors new_Visitors )
        {
            string cs = @"Data Source=ROHIT-LAPTOP-6-\SQLEXPRESS;Initial Catalog=ecom_database;Integrated Security=True; TrustServerCertificate = True";

            SqlConnection sqlConnection = new SqlConnection(cs);
            string command = "insert into NEW_VISITORS values(@visitors_Email)";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);

            if (new_Visitors != null)
            {
                sqlConnection.Open();
                cmd.Parameters.Add("@visitors_Email", new_Visitors.visitors_Email);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return RedirectToAction("User_Index", "User_Index");

            return View();
        }
    }
}