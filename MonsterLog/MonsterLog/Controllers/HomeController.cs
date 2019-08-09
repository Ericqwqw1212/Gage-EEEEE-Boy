using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MonsterLog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Monsters()
        {
            return View();
        }

        public IActionResult Random()
        {
            return View();
        }

        public IActionResult Favorites()
        {
            return View();
        }
    }
}