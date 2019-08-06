using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterLog.Models
{
    public class Monster
    {
        public string Image { get; set; }
        public string Lore { get; set; }

        public string Name { get; set; }
        public int LifeSpan { get; set; }
        public int Weight { get; set; }
        public int Size { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }
        public string NaturalStrengths { get; set; }
        public string NaturalWeakness { get; set; }
    }
}
