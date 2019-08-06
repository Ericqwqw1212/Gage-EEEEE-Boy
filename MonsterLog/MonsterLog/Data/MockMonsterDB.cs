using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MockMonsterDB : IMonsterDAL
    {
        private static List<Monster> monters = new List<Monster>();
        public IEnumerable<Monster> AllMonsters()
        {
            return monters;
        }
    }
}
