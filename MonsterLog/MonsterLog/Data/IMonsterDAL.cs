using MonsterLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterLog.Data
{
    interface IMonsterDAL
    {
        IEnumerable<Monster> AllMonsters();
        IEnumerable<Monster> FavoriteMonsters();
        IEnumerable<Monster> SearchMonsters(string search);
        IEnumerable<Monster> FilterMonsters(string habitat);
        void Favorite(int index);
        void SingleMonster(int index);

    }
}
