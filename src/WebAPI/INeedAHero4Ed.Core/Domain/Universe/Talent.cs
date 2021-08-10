using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class Talent : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public AttributeType MaxAttribute { get; set; }
        public byte MaxConst { get; set; }
        public LocalizationSet MaxDescriptive { get; set; }
        public ISet<AttributeType> TestAttributes { get; set; }
        public ISet<Skill> RelatedSkills { get; set; }
    }
}