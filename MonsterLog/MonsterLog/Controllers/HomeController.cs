using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MonsterLog.Models;

namespace MonsterLog.Controllers
{
    public class HomeController : Controller
    {
        Monster monster = new Monster
        {
            Name = "Qwqw",
            LifeSpan = "Imortal",
            Weight = "150",
            Size = "6ft",
            Diet = "Raw Spaggeti",
            Habitat = "All",
            NaturalStrengths = "Hive Mind",
            NaturalWeakness = "Gage EEEEE Boy",
            Lore = "llllllllllllllllllllllllllllllllllllllllllll"
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Monsters()
        {
            return View(monster);
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