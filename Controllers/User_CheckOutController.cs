using NEW_E_COMMERCE_WEB_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class User_CheckOutController : Controller
    {
        // GET: User_CheckOut
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckOut(CheckOut checkOut)
        {

            if (checkOut != null)
            {
                if (ModelState.IsValid)
                {
                    string cs = @"Data Source=ROHIT-LAPTOP-6-\SQLEXPRESS;Initial Catalog=ecom_database;Integrated Security=True; TrustServerCertificate = True";

                    SqlConnection sqlConnection = new SqlConnection(cs);
                    string command = "insert into tbl_customer values(@firstname,@lastname,@country,@address,@city,@state,@mob_number,@email,@account_Password,@order_Note)";
                    SqlCommand cmd = new SqlCommand(command, sqlConnection);

                        sqlConnection.Open();
                        cmd.Parameters.Add("@firstname", checkOut.firstname);
                        cmd.Parameters.Add("@lastname", checkOut.lastname);
                        cmd.Parameters.Add("@country", checkOut.country);
                        cmd.Parameters.Add("@address", checkOut.address);
                        cmd.Parameters.Add("@city", checkOut.city);
                        cmd.Parameters.Add("@state", checkOut.state);
                        cmd.Parameters.Add("@mob_number", checkOut.mob_number);
                        cmd.Parameters.Add("@email", checkOut.email);
                        cmd.Parameters.Add("@account_Password", checkOut.account_Password);
                        cmd.Parameters.Add("@order_Note", checkOut.order_Note);
                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    
                    return RedirectToAction("User_Index", "User_Index");

                    return View();
                }
            }
            return View();
        }
    }
}