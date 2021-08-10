using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class ProfessionClass : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public ISet<Profession> Professions { get; set; }
    }
}