using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class ProfessionLevel : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public Profession Profession { get; set; }
        public byte Level { get; set; }
        public Status Status { get; set; }
        public ISet<AttributeType> Attributes { get; set; }
        public ISet<Skill> Skills { get; set; }
        public ISet<Talent> Talents { get; set; }
        public ICollection<Trapping> Trappings { get; set; }
    }
}