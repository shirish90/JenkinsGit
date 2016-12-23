using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JenkinsDemo2.Models;

namespace JenkinsDemo2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Home obj = new Home();
            int A = obj.value1 = 2;
            int B = obj.value2 = 2;

            obj.output = A * B;


            return View(obj);
        }

        [HttpPost]
        public ActionResult FormProcess(Home obj)
        {
            int A = obj.value1;
            int B = obj.value2;

            obj.output = A * B;


            return View("Home/Index", obj);
            //return RedirectToAction("Index", "Home");
        }
    }
}