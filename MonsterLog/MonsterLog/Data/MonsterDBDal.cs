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
            if (_monsterContext.Monsters.ToList().Count == 0)
            {
                AddDefaultList();
            }

            return _monsterContext.Monsters.ToList();
        }
        public int AddDefaultList()
        {
            //When adding a new monster put it in this list, then have everyone set thier SQL monster list to null.
            List<Monster> monsters = new List<Monster>() {
                    new Monster
                    {
                        Image ="wendigo.jpg",
                        Name ="Wendigo",
                        Lore ="A horrific creature formed by necessity driven hunger gone mad. In the vast expanses of the Boreal Realms, there exists legends of the indigenous people. Legends to explain ideas greater than themselves. Legends to pass lessons of life from elder to minor. Stories of heroes, and cryptids battling in a never ceasing battles of good and evil. Of these legends, one of the most fearsome of these cryptids is the Dreaded Wendigo. A spirit of cannibalism that possesses the weak of will. When tribesmen are isolated in their homes, trapped by the deep snows and treacherous cold, and the scarcity of food seeps deeper into the soul, the ravenous nature of the Wendigo begins to take hold.",

                        Habitat ="Habitat:Boreal Realm",
                        LifeSpan ="Lifespan:25 years",
                        Diet ="Canabalistic",
                        Size ="Medium",
                        NaturalStrengths ="Resist: Necrotic --- Immune: Cold, Poison, Charm, Exhaustion, Poisoned --- Notable Skills: Mimicry, The wendigo can mimic any sounds it has heard, including voices. --- A creature that hears the sounds can tell they are imitations with a successful DC 14 Wisdom (Insight) check. Masks of the Wild, The wendigo can attempt to hide even when it is only lightly obscured by foliage, heavy rain, falling snow, mist, or other natural phenomena. Stats: 15 str, 17 dex, 14 con, 11 int, 10 wis, 16 cha --- " ,

                        NaturalWeakness="Weak to Fire"
                    }, //Windigo

                    new Monster
                    {
                        Image ="seaSerpent.jpg",
                        Name ="Sea Serpent",
                        Diet ="Living creatures",
                        Habitat ="Habitat:Sea",
                        LifeSpan ="Lifespan:250-300 years",
                        Size ="Gargantuan",
                        NaturalWeakness ="No known weaknesses, Good luck",

                        NaturalStrengths="It's size, Able to hold breath for an hour --- " +
                                        "Notable Skills: Siege Monster-The serpent deals double damage to objects and structures. --- " +
                                        "Stats: 26 str, 13 dex, 22 con, 10 int, 14 wis, 10 cha",

                        Lore ="Fully grown sea serpents can be longer than ships, and they hunt massive prey. " +
                        "They have been known to attack ships, dragging them beneath the waves with their massive coils, " +
                        "and devouring entire crews in a single gulp, before dragging the husks away to build their nests. " +
                        "They can live for centuries, and a single sea serpent's nest might have ships from eras ago, long thought vanished. " +
                        "Their nests also often have the treasures of their victims, but the sea serpents care little for such trinkets. " +
                        "They lay their eggs in such nests, for even the youngest of newly hatched sea serpents can hold their breath far longer than any land-based humanoid as tides ebb and flow around the nests. " +
                        "Some sea serpents that find their way to the Plane of Elemental Water become servants of marids, driving creatures away from places the marid wishes to be undisturbed or serving as mounts."
                    }, //Sea Serpent

                    new Monster
                    {
                        Image = "abbadonsLocusts.jpg",
                        Name = "Abbadon Locusts",
                        LifeSpan = "Indefinite",
                        Size = "Gargantuan",
                        Habitat = "Air/Anywhere",
                        Diet = "Living",

                        NaturalStrengths = "Resistances: bludgeoning, piercing, slashing. --- " +
                                            "Immunities: charmed, frightened, grappled, paralyzed, petrified, prone, restrained, stunned --- " +
                                            "Stats: 26 str, 13 dex, 22 con, 10 int, 14 wis, 10 cha",

                        NaturalWeakness = "None",

                        Lore = "The locusts looked like horses prepared for battle. " +
                                "On their heads they wore something like crowns of gold, and their faces resembled human faces. " +
                                "Their hair was like women's hair, and their teeth were like lions' teeth. " +
                                "They had breastplates like breastplates of iron, and the sound of their wings was like the thundering of many horses and chariots rushing into battle. " +
                                "They had tails with stingers, like scorpions, and in their tails they had power to torment people for five months."
                    }, //Abbadon's Locusts

                    new Monster
                    {
                        Image = "adrammelech.png",
                        Name = "Adrammelech, the Wroth",
                        LifeSpan = "Unknown",
                        Size = "Huge",
                        Habitat = "Zertinan Caverns",
                        Diet = "Unknown",

                        NaturalStrengths = "Resistances: thunder, poison, bludgeoning, piercing, and slashing damage from nonmagical weapons --- " +
                                            "Immunities: lightning, blinded, charmed, deafened, frightened, paralyzed, petrified, poisoned, sleep --- " +
                                            "Stats: 27 str, 19 dex, 22 con, 17 int, 18 wis, 20 cha",

                        NaturalWeakness = "None",

                        Lore = "Adrammelech the Wroth is a powerful fiend and one of the twelve Lucavi, beings who were created to serve the gods but rose up against them in revolt instead. " +
                        "The gods cast the Lucavi down for their transgressions, " +
                        "twisting their once noble forms into hideous mockeries and binding them to magical glyphs that would limit their once-great power."

                    }, //Adrammelech, the Wroth

                    new Monster
                    {
                        Image = "adze.jpg",
                        Name = "Adze",
                        LifeSpan = "60 yrs",
                        Size = "Medium",
                        Habitat = "Unknown",
                        Diet = "Blood",

                        NaturalStrengths = "Resistances: bludgeoning, piercing, and slashing from nonmagical attacks --- " +
                                            "Immunities: cold, necrotic, poison, charmed, frightened, poisoned --- " +
                                            "Stats: 16 str, 16 dex, 18 con, 12 int, 14 wis, 14 cha",

                        NaturalWeakness = "None",

                        Lore = "The adze is a vampire that takes the form of a firefly, but if you capture one, it will revert to human appearance. " +
                                "This can be dangerous in itself, because in its human form the adze may attack and eat your organs, but it can be defeated. " +
                                "However, in the insect form, the adze will suck your blood while you sleep and spread disease, which is a possible explanation for outbreaks. " +
                                "Its preferred victims are young children. " +
                                "The victim of an adze becomes a witch who is possessed by the adze’s spirit."

                    }, //Adze

                    new Monster
                    {
                        Image = "demizenVampire.jpg",
                        Name = "Demizen Vampire",
                        LifeSpan = "Immortal",
                        Size = "Large",
                        Habitat = "Unknown",
                        Diet = "Blood",

                        NaturalStrengths = "Resistances: bludgeoning, piercing and slashing from nonmagical attacks made with silvered attacks --- " +
                                            "Immunities: necrotic, poison, frightened, poisoned, paralyzed, exhaustion, sleep, charmed, petrified --- " +
                                            "Stats: 24 str, 24 dex, 24 con, 22 int, 20 wis, 29 cha ",

                        NaturalWeakness = "Vulnerabilities: radiant",

                        Lore = "Vampire lords often have numerous undead beside it, usually freshly killed and animated and bent to its will. " +
                                "They usually fly above the battlefield using their impressive wingspan to soar above the battlefield unleashing spells of death upon its foes often unbeknownst to those below with its innate ability to become invisible. " +
                                "When that fails, the vampire lord is no slouch when it comes to hand to hand combat as their very touch can kill a creature where it stands only to have it serve its new master when it falls. " +
                                "With its dealings with necromancy and its natural undeath, it uses these innate necromantic abilities to further its vitality and siphon the very life energy of those around them making if difficult for any to even get close to it. " +
                                "Very few vampires live the millennia it takes to become a vampire lord and even fewer master their new found abilities. " +
                                "Though rumors say that the process to become a vampire lord is within the pages of the Book of Vile Darkness. " +
                                "Even so, one must be a vampire to do anything with the ritual, all others will only become lifeless shells of their former selves. " +
                                "Be wary when facing this master of death as it may be the last time you are truly alive of your own free will."

                    }, //Demizen Vampire

                    new Monster
                    {
                        Image = "ogreWarlord.jpg",
                        Name = "Ogre Warlord",
                        LifeSpan = "90 Yrs",
                        Size = "Large",
                        Habitat = "Swamp",
                        Diet = "Humans",

                        NaturalStrengths = "Hard to Frighten --- " +
                        "Stats: 22 str, 9 dex, 14 con, 22 int, 20 wis, 29 cha ",

                        NaturalWeakness = "None",

                        Lore = "An ogre (feminine: 'ogress') is a legendary monster usually depicted as a large, hideous, man-like being that eats ordinary human beings, especially infants and children. " +
                        "Ogres frequently feature in mythology, folklore, and fiction throughout the world. " +
                        "They appear in many classic works of literature, and are most often associated in fairy tales and legend with a taste for infants."

                    }, //Ogre Warlord

                    new Monster
                    {
                        Image = "murloc.jpg",
                        Name = "Murloc",
                        LifeSpan = "Unknown, Possibly Immortal",
                        Size = "Small",
                        Habitat = "Anything Near a Body of Water",
                        Diet = "Unkown",

                        NaturalStrengths = "Immunities: Poison --- " +
                        "Stats: 8 str, 15 dex, 13 con, 10 int, 11 wis, 9 cha ",

                        NaturalWeakness = "None",

                        Lore = "The murloc is a bipedal, amphibious, semi-intelligent, aggressive race residing along coastlines, lakeshores, and riverbeds. " +
                        "Murlocs possess bulbous bodies, large mouths lined with rows of sharp fangs, and slime-coated skin. " +
                        "Individuals range in coloration from turquoise to darkish grey, while their heights vary from 3-1/2 feet to 6 feet. " +
                        "Depending on the variety, murlocs may lean towards a closer resemblance to frogs or to fish; the iconic green murloc, for example, has coloration similar to the red-eyed tree frog."

                    }, //Murloc

                    new Monster
                    {
                        Image = "paleHorse.jpg",
                        Name = "Pale Horse",
                        LifeSpan = "25-30 yrs",
                        Size = "Large",
                        Habitat = "Anywhere",
                        Diet = "Herbivore",

                        NaturalStrengths = "Resistances: Necrotic, Radiant",

                        NaturalWeakness = "None",

                        Lore = "This is one of a group of necrotic horses. The others are pale yearling, pale stallion, and the pale pegasus."

                    }, //Pale Horse

                    new Monster
                    {
                        Image = "pachycephalosaurus.jpg",
                        Name = "Pachycephalosaurus",
                        LifeSpan = "Unknown",
                        Size = "Large",
                        Habitat = "North America (Montana, South Dakota, Wyoming)",
                        Diet = "Either herbivore or omnivore",

                        NaturalStrengths = "None",

                        NaturalWeakness = "None",

                        Lore = "The pachycephalosaurus is a quick-footed herbivore, with a bad temper. While not the largest among dinosaurs, pachycephalosaurus sports a damaging weapon in its own right; a thick, bony dome and short bony spikes projecting upward all atop its head. These dinosaurs are spotted usually in small groups or gangs and are highly territorial, using their thick skulls as battering rams."

                    }, //Pachycephalosaurus

                    new Monster
                    {
                        Image = "pathiel.png",
                        Name = "Pathiel",
                        LifeSpan = "Immortal",
                        Size = "Large",
                        Habitat = "Divine Locations",
                        Diet = "None",

                        NaturalStrengths = "Resistances: radiant, bludgeoning, piercing, and slashing from non magical weapons",

                        NaturalWeakness = "None except maybe the seduction and allure of humans",

                        Lore = "A Pathiel is an angel of great power and is said to bring prosperity. These angels are sent by gods as guardians of the weak as wars are waged in their names, so that their followers are protected from the harsh environments of the world. These angels can create wonderful feasts and heal the wounded. These angels only protect those who aren't fighting as the gods created them to protect their followers, not to fight battles. These Angels only appear when these conditions are met"

                    },//Pathiel

                    new Monster
                    {
                        Image = "affinity.jpg",
                        Name = "Affinity",
                        LifeSpan = "Immortal",
                        Size = "Medium",
                        Habitat = "Divine Locations",
                        Diet = "None",

                        NaturalStrengths = "Resistances: radiant; bludgeoning, piercing and slashing damage from nonmagical attacks",

                        NaturalWeakness = "None",

                        Lore = "ervants of heaven that populate the lowest of the angelic hierarchy, a third sphere rung known simply as angels. Those with deep faith often feel these angels closest to their hearts. Descending from the heavens upon their pure white wings, it is believed that the glimmering halo atop an affinity's head lights the path for those who have lost their way."

                    },//Affinity

                    new Monster
                    {
                        Image = "ajin.jpg",
                        Name = "Ajin",
                        LifeSpan = "Unkown",
                        Size = "Medium",
                        Habitat = "Anywhere",
                        Diet = "Mone",

                        NaturalStrengths = "Resistances: Everything",

                        NaturalWeakness = "Water",

                        Lore = "An Ajin is a creature that cannot be seen or heard by all creatures and humanoids except those that own one. Some owners are able to control their Ajin completely whereas some Ajin simply do whatever it wants. While other Owners are able to command their Ajin properly and can share their Ajin's field of vision and command it to attack targets.Some Ajin are reckless, and often attacks anyone in its immediate vicinity."

                    },//Ajin

                    new Monster
                    {
                        Image = "allegiance.jpg",
                        Name = "Allegiance",
                        LifeSpan = "Immortal",
                        Size = "Large",
                        Habitat = "Divine Locations",
                        Diet = "None",

                        NaturalStrengths = "Resistances: radiant; bludgeoning, piercing and slashing damage from nonmagical attacks",

                        NaturalWeakness = "None",

                        Lore = "Allegiance belongs to the principalities, ranked seventh in the angelic hierarchy and part of the third sphere. While third sphere angels are the most common type encountered in the physical realm, allegiance, clad in solid gold armor, appears only during times of strife between the celestial plane and the human world, in order to purge the armies of evil spirits."

                    },//Allegiance

                    new Monster
                    {
                        Image = "aknamkanon.jpg",
                        Name = "Aknamkanon",
                        LifeSpan = "Unknown",
                        Size = "Medium",
                        Habitat = "Unkown",
                        Diet = "Unkown",

                        NaturalStrengths = "None",

                        NaturalWeakness = "None",

                        Lore = "Aknomkanon the name when said is feared most dwell in their homes for the sight of of him will bring a shiver down your spine. His execution schedule is like none ever seen he will kill anything he wants to just because he's bored."

                    },//Aknamkanon

                    new Monster
                    {
                        Image = "cthulhu.jpg",
                        Name = "Cthulhu",
                        LifeSpan = "Immortal",
                        Size = "Gargantuan",
                        Habitat = "Ocean",
                        Diet = "Sacrifices",

                        NaturalStrengths = "Immunities: necrotic, poison, psychic; bludgeoning, piercing, and slashing from nonmagical attacks",

                        NaturalWeakness = "None",

                        Lore = "Great Cthulhu is one of the Great Old Ones, a god-like being asleep somewhere under the ocean. Currently trapped, Cthulhu will eventually awaken, an event subconsciously feared by all sentient races."

                    },//Cthulhu

                    new Monster
                    {
                        Image = "enchant.jpg",
                        Name = "Enchant",
                        LifeSpan = "Immortal",
                        Size = "Medium",
                        Habitat = "Divine Locations",
                        Diet = "None",

                        NaturalStrengths = "Resistances: radiant; bludgeoning, piercing and slashing damage from nonmagical attacks",

                        NaturalWeakness = "None",

                        Lore = "An Angel shaped like a cart wheel. Enchants are designed to compel humanity to continue its struggle and feel no satisfaction at surpassing others. Enchants protect the fields of the gods from human encroachment and are further responsible for passing communication to the Celestial Plane and correcting the trespasses of humanity."

                    },//Enchant


                };

            _monsterContext.AddRange(monsters);

            return _monsterContext.SaveChanges();
        }

        public IEnumerable<Monster> SearchMonsters(string name, string habitat)
        {
            var searched = from m in GetAllMonsters()
                           select m;

            if (!string.IsNullOrEmpty(name))
            {
                searched = searched.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
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
            return _monsterContext.Monsters.ToList().ElementAt(index);
        }
    }
}
