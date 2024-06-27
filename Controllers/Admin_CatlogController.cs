using NEW_E_COMMERCE_WEB_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class Admin_CatlogController : Controller
    {
        // GET: Admin_Catlog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin_catlog_categories()
        {
            //ViewBag.Message = "Categories";
            //IList<Categories> categories = new List<Categories>() {
            //new Categories() { CategoryId =1,CategoryName="Camera",SortOrder=1 },
            //new Categories() { CategoryId =2,CategoryName="Mobile",SortOrder=2},
            //new Categories() { CategoryId =3,CategoryName="Furniture",SortOrder=3 },
            //new Categories() { CategoryId =4,CategoryName="Car",SortOrder=4},
            //};

            //ViewBag.Categories = categories;

            
            return View();
        }

        public ActionResult Admin_catlog_Product()
        {

            return View();
        }
        public ActionResult Admin_catlog_Add_Category()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Admin_catlog_Add_Category(tbl_category tbl_Category)
        {
            string cs = @"Data Source=ROHIT-LAPTOP-6-\SQLEXPRESS;Initial Catalog=ecom_database;Integrated Security=True; TrustServerCertificate = True";
            string command = "insert into tbl_category values (@Category_Name)";

            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(command, conn);

            conn.Open();
            cmd.Parameters.Add("@Category_Name", tbl_Category.Category_Name);

            
            cmd.ExecuteNonQuery();
            conn.Close();
            return View();
        }

        public ActionResult Admin_catlog_Add_Product()
        {

            return View();
        }

    }
}