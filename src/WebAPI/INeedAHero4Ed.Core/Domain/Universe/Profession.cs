using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class Profession : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public LocalizationSet Description { get; set; }
        public ProfessionClass ProfessionClass { get; set; }
        public ISet<ProfessionLevel> ProfessionLevels { get; set; }
    }
}