using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TurningPoint.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult Facultyhome()
        {
            return View();
        }
        public ActionResult Upload()
        {
            return View();
        }
    }
}