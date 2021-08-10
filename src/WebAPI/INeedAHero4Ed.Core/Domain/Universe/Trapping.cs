using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public class Trapping : EntityFromPlaceInBook
    {
        public LocalizationSet Name { get; set; }
        public LocalizationSet Description { get; set; }
        public short Weight  { get; set; }
    }
}