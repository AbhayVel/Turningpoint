using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace apurvaProject1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Adminhome()
        {
            return View();
        }
        public ActionResult Facaluty()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Notes()
        {
            return View();
        }
    }
}