using Microsoft.Ajax.Utilities;
using NEW_E_COMMERCE_WEB_APPLICATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult UserLogin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UserLogin(tbl_user tbl_User)
        {
            try { 
            if (tbl_User == null)
            {
                
            }
            else  if (tbl_User != null)
            {
                if (ModelState.IsValid)
                {
                    ecom_databaseEntities ecom_DatabaseEntities = new ecom_databaseEntities();

                    var obje = ecom_DatabaseEntities.tbl_user.Where
                    (e => e.email.Equals(tbl_User.email) && e.password.Equals(tbl_User.password)).FirstOrDefault();

                    if (obje != null)
                    {
                        return RedirectToAction("User_Index", "User_Index");
                    }
                }
            }
            }catch (Exception ex)
            {

            }
            return View(tbl_User);
        }

        public ActionResult User_Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult User_Registration(tbl_user TB_USER)
        {
            if (TB_USER != null)
            {
                if (ModelState.IsValid)
                {
                    ecom_databaseEntities ecom_DatabaseEntities = new ecom_databaseEntities();
                    ecom_DatabaseEntities.tbl_user.Add(TB_USER);
                    ecom_DatabaseEntities.SaveChanges();
                    return RedirectToAction("UserLogin", "UserLogin");
                }
            }
            
            
            return View(TB_USER);
        }


    }
}