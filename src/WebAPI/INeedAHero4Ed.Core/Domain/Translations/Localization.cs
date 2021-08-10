using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Translations
{
    public class Localization : Entity
    {
        public int LocalizationSetId { get; set; }
        public string CultureCode { get; set; }
        public string Value { get; set; }

        public virtual LocalizationSet LocalizationSet { get; set; }
        public virtual Culture Culture { get; set; }
    }
}