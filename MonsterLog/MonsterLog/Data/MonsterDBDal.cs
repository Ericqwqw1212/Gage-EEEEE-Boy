using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MonsterDBDal : IMonsterDAL
    {
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
            throw new NotImplementedException();
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
