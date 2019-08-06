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
            favorites.Add(monsters[index]);
        }

        public IEnumerable<Monster> FavoriteMonsters()
        {
            return favorites;
        }

        public IEnumerable<Monster> FilterMonsters(string habitat)
        {
            var searched = from m in monsters
                           select m;

            if (!string.IsNullOrEmpty(habitat))
            {
                searched = searched.Where(s => s.Habitat.Contains(habitat, StringComparison.OrdinalIgnoreCase));
            }
            List<Monster> filtered = new List<Monster>();
            filtered.AddRange(searched);
            return filtered;
        }

        public IEnumerable<Monster> SearchMonsters(string search)
        {
            var searched = from m in monsters
                           select m;

            if (!string.IsNullOrEmpty(search))
            {
                searched = searched.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            List<Monster> filtered = new List<Monster>();
            filtered.AddRange(searched);
            return filtered;
        }

        public void SingleMonster(int index)
        {
            throw new NotImplementedException();
        }
    }
}
