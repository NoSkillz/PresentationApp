using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationApp.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Results
        public ActionResult Index(string result)
        {
            ViewBag.Result = result;
            return View();
        }
    }
}