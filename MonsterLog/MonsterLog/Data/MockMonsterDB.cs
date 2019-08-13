using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MockMonsterDB : IMonsterDAL
    {
        private static List<Monster> monsters = new List<Monster>() { new Monster { Image="wendigo.jpg",Name="Wendigo", Lore="A horrific creature formed by necessity driven hunger gone mad.In the vast expanses of the Boreal Realms, there exists legends of the indigenous people. Legends to explain ideas greater than themselves."
            +" Legends to pass lessons of life from elder to minor. Stories of heroes, and cryptids battling in a never ceasing battles of good and evil. Of these legends, one of the most fearsome of these cryptids"
            +" is the Dreaded Wendigo. A spirit of cannibalism that possesses the weak of will. When tribesmen are isolated in their homes, trapped by the deep snows and treacherous cold, and the scarcity of"
            +" food seeps deeper into the soul, the ravenous nature of the Wendigo begins to take hold.", Habitat="Boreal Realm", LifeSpan="25 years", Diet="Carnivourous",Size="Medium"
            , NaturalStrengths="Resist: Necrotic| Immune: Cold, Poison, Charm, Exhaustion, Poisoned| Stats: 15str, 17dex, 14con, 11int, 10wis, 16cha| " +
            "Notable Skills: Mimicry, The wendigo can mimic any sounds it has heard, including voices. A creature that hears the sounds can tell they are imitations with a successful DC 14 Wisdom (Insight) check." +
            "Masks of the Wild, The wendigo can attempt to hide even when it is only lightly obscured by foliage, heavy rain, falling snow, mist, or other natural phenomena."
            , NaturalWeakness="Fire"} };
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

        public IEnumerable<Monster> SearchMonsters(string search, string habitat)
        {
            var searched = from m in monsters
                           select m;

            if (!string.IsNullOrEmpty(search))
            {
                searched = searched.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(habitat))
            {
                searched = searched.Where(s => s.Habitat.Contains(habitat, StringComparison.OrdinalIgnoreCase));
            }
            List<Monster> filtered = new List<Monster>();
            filtered.AddRange(searched);
            return filtered;
        }

        public Monster SingleMonster(int index)
        {
            return monsters[index];
        }
    }
}
