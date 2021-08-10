using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Translations;

namespace INeedAHero4Ed.Core.Domain.Universe.Base
{
    public class Book : Entity
    {
        public LocalizationSet Name { get; set; }
    }
}