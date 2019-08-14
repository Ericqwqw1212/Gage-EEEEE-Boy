using MonsterLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterLog.Data
{
    public interface IMonsterDAL
    {
        IEnumerable<Monster> AllMonsters();
        IEnumerable<Monster> FavoriteMonsters();
        IEnumerable<Monster> SearchMonsters(string search, string habitat);
        void Favorite(int index);
        Monster SingleMonster(int index);

    }
}
