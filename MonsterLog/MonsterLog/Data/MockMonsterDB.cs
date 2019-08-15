using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterLog.Models;

namespace MonsterLog.Data
{
    public class MockMonsterDB : IMonsterDAL
    {
        private static List<Monster> monsters = new List<Monster>() {
            new Monster { Image="wendigo.jpg",Name="Wendigo", Lore="A horrific creature formed by necessity driven hunger gone mad.In the vast expanses of the Boreal Realms, there exists legends of the indigenous people. Legends to explain ideas greater than themselves."
                +" Legends to pass lessons of life from elder to minor. Stories of heroes, and cryptids battling in a never ceasing battles of good and evil. Of these legends, one of the most fearsome of these cryptids"
                +" is the Dreaded Wendigo. A spirit of cannibalism that possesses the weak of will. When tribesmen are isolated in their homes, trapped by the deep snows and treacherous cold, and the scarcity of"
                +" food seeps deeper into the soul, the ravenous nature of the Wendigo begins to take hold.", Habitat="|Habitat:Boreal Realm|", LifeSpan="Lifespan:25 years|", Diet="|Canabalistic",Size="Medium|"
                , NaturalStrengths="Resist: Necrotic| Immune: Cold, Poison, Charm, Exhaustion, Poisoned| Stats: 15str, 17dex, 14con, 11int, 10wis, 16cha| " +
                "Notable Skills: Mimicry, The wendigo can mimic any sounds it has heard, including voices. A creature that hears the sounds can tell they are imitations with a successful DC 14 Wisdom (Insight) check." +
                "Masks of the Wild, The wendigo can attempt to hide even when it is only lightly obscured by foliage, heavy rain, falling snow, mist, or other natural phenomena."
                , NaturalWeakness="Fire"},
            new Monster{ Image="seaSerpent.jpg", Name="Sea Serpent", Diet="|Living creatures", Habitat="|Habitat:Sea|", LifeSpan="Lifespan:250-300 years|", Size="Gargantuan|", NaturalWeakness="None known, Good luck",
                NaturalStrengths="It's size| Able to hold breath for an hour| Notable Skills: Siege Monster-The serpent deals double damage to objects and structures. Swallow. The serpent makes one bite attack against a Large or smaller " +
                "creature it is grappling. If the attack hits, that creature takes the bite's damage and is swallowed, and the grapple ends. While swallowed, the creature is blinded and restrained, it has total cover against attacks" +
                " and other effects outside the serpent, and it takes 21 (6d6) acid damage at the start of each of the serpent's turns.If the serpent takes 30 damage or more on a single turn from a creature inside it, the serpent " +
                "must succeed on a DC 21 Constitution saving throw at the end of that turn or regurgitate all swallowed creatures, which fall prone in a space within 10 feet of the serpent. If the serpent dies, a swallowed creature " +
                "is no longer restrained by it and can escape from the corpse using 20 feet of movement, exiting prone.| Stats:26str, 13dex, 22con, 10int, 14wis, 10cha", Lore="Fully grown sea serpents can be longer than ships, and " +
                "they hunt massive prey. They have been known to attack ships, dragging them beneath the waves with their massive coils, and devouring entire crews in a single gulp, before dragging the husks away to build their " +
                "nests. They can live for centuries, and a single sea serpent's nest might have ships from eras ago, long thought vanished. Their nests also often have the treasures of their victims, but the sea serpents care" +
                " little for such trinkets. They lay their eggs in such nests, for even the youngest of newly hatched sea serpents can hold their breath far longer than any land-based humanoid as tides ebb and flow around the " +
                "nests. Some sea serpents that find their way to the Plane of Elemental Water become servants of marids, driving creatures away from places the marid wishes to be undisturbed or serving as mounts."} };

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
