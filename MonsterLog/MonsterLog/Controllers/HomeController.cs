using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonsterLog.Data;
using MonsterLog.Models;

namespace MonsterLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMonsterDAL monsterContext;

        public HomeController(IMonsterDAL context) : base()
        {
            monsterContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Monsters()
        {
            return View(monsterContext.GetAllMonsters().ToList());
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