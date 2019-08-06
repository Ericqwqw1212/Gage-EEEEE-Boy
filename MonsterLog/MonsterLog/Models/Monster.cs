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
        public string LifeSpan { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }
        public string NaturalStrengths { get; set; }
        public string NaturalWeakness { get; set; }
    }
}
