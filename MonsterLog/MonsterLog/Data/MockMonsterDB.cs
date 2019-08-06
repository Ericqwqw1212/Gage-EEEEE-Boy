using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MockMonsterDB : IMonsterDAL
    {
        private static List<Monster> monsters = new List<Monster>();
        private static List<Monster> favorites = new List<Monster>();
        public IEnumerable<Monster> AllMonsters()
        {
            return monsters;
        }

        public void Favorite(int index)
        {
            //favorites
        }

        public IEnumerable<Monster> FavoriteMonsters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monster> FilterMonsters(string habitat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monster> SearchMonsters(string search)
        {
            throw new NotImplementedException();
        }

        public void SingleMonster(int index)
        {
            throw new NotImplementedException();
        }
    }
}
