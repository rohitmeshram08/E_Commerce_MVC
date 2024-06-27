using NEW_E_COMMERCE_WEB_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(tbl_admin tbl_Admin )
        {
            if (tbl_Admin != null)
            {
                if (ModelState.IsValid)
                { 
                      ecom_databaseEntities ecom_DatabaseEntities = new ecom_databaseEntities();
                 
                        var obje = ecom_DatabaseEntities.tbl_admin.Where
                        ( e => e.email.Equals(tbl_Admin.email)&& e.password.Equals(tbl_Admin.password)).FirstOrDefault();

                    if (obje != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            } return View();
        }
        public ActionResult Admin_Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin_Registration( tbl_admin tbl_Admin)
        {
            if (tbl_Admin != null)
            {
                if (ModelState.IsValid)
                {
                    ecom_databaseEntities ecom_DatabaseEntities = new ecom_databaseEntities();

                    ecom_DatabaseEntities.tbl_admin.Add(tbl_Admin);
                    ecom_DatabaseEntities.SaveChanges();
                    return RedirectToAction("AdminLogin", "AdminLogin");
 
                }
            }
            return View(tbl_Admin);
        }
    }
}