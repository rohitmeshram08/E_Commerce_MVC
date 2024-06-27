using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class Admin_SalesController : Controller
    {
        // GET: Admin_Sales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin_Sales_Orders() 
        {
            return View();
        }
    }
}