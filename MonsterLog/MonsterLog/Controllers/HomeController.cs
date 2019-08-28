using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public IActionResult Monsters(int page)
        {
            ViewBag.Page = page;
            return View(monsterContext.GetAllMonsters());
        }
        [HttpPost]
        public IActionResult Monsters(int page, string name, string habitat)
        {
            ViewBag.Page = page;
            return View(monsterContext.SearchMonsters(name, habitat));
        }

        public IActionResult RandomMonster(int? index=null)
        {
            List<Monster> mons = monsterContext.GetAllMonsters().ToList();
            int mon = index == null ? new Random().Next(mons.Count) : int.Parse(index.ToString());
    
            Monster random = monsterContext.SingleMonster(mon);
            return View(random);
        }
        [Authorize]
        public IActionResult Favorites()
        {
            return View();
        }
    }
}