using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MonsterDBDal : IMonsterDAL
    {
        private readonly MonsterDBContext _monsterContext;

        public MonsterDBDal(MonsterDBContext monsterContext)
        {
            _monsterContext = monsterContext;
        }

        public void Favorite(int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monster> FavoriteMonsters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Monster> GetAllMonsters()
        {
            foreach (Monster mon in _monsterContext.Monsters)
            {
                _monsterContext.Update(mon);
            }
            _monsterContext.SaveChanges();
            return _monsterContext.Monsters;
        }

        public IEnumerable<Monster> SearchMonsters(string search, string habitat)
        {
            throw new NotImplementedException();
        }

        public Monster SingleMonster(int index)
        {
            throw new NotImplementedException();
        }
    }
}
