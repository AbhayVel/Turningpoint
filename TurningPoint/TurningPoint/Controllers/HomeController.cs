﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace apurvaProject1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult HowItWorks()
        {
            return View();
        }
       
            public ActionResult SignUp()
        {
            List<SelectListItem> f = new List<SelectListItem>();
            f.Add(new SelectListItem { Text = "Student", Value = "Student" });
            f.Add(new SelectListItem { Text = "Faculty", Value = "Faculty" });
            ViewBag.Filds = f;
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
    }
}