using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            var obj = new { id= 1,Name= "Sri" };
            return View(obj);
        }

        public ViewResult Aboutus()
        {
            return View();
        }

        public ViewResult Contactus()
        {
            return View();
        }
    }
}
