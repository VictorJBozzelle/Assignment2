using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Venus()
        {
            return View();
        }
        public ViewResult Earth()
        {
            return View();
        }
        public ViewResult Mars()
        {
            return View();
        }
        public ViewResult Jupiter()
        {
            return View();
        }
        public ViewResult Uranus()
        {
            return View();
        }
    }
}
