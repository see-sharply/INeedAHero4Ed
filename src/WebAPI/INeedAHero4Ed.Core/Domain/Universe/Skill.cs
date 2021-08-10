using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class Skill : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public LocalizationSet Description { get; set; }
        public AttributeType AttributeType { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public bool IsForGroup { get; set; }
        public ISet<Talent> RelatedTalents { get; set; }
    }
}