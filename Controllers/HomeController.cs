using FirestMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirestMVCApp.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            var data = GetEmployees();
            return View(data);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public Employee GetEmployees()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Sameer"

            };
        }
    }
}