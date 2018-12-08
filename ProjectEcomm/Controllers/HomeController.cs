using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectEcomm.Data;

namespace ProjectEcomm.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _myContext;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
    }
}