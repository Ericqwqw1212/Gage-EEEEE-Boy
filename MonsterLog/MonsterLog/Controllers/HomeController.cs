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
            return View();
        }

        public IActionResult RandomMonster(int? index=null)
        {
            List<Monster> mons = monsterContext.AllMonsters().ToList();
            int mon = index == null ? new Random().Next(mons.Count) : int.Parse(index.ToString());
    
            Monster random = monsterContext.SingleMonster(mon);
            return View(random);
        }

        public IActionResult Favorites()
        {
            return View();
        }
    }
}