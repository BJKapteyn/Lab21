﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            
            return View();
        }

        public ActionResult SubmissionView(Registration register)
        {
            if(register.password.Length < 8)
            {
                Session["Error"] = "Make sure the password is more than 8 characters long.";
                return RedirectToAction("Register");
            }
            if(register.password != register.rePassword)
            {
                Session["Error"] = "The passwords did not match";
                return RedirectToAction("Register");
            }
            ViewBag.name = register.name;
            ViewBag.password = register.password;
            ViewBag.email = register.email;
            ViewBag.coffeeType = register.coffeeType;
            ViewBag.hotOrCold = register.hotOrCold;
            return View();
        }

        public ActionResult Properties()
        {
            return View();
        }
    }
}