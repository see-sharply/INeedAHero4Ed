using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Translations
{
    public class LocalizationSet : Entity
    {
        public virtual ICollection<Localization> Localizations { get; set; }
    }
}