using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Universe.Base;

namespace INeedAHero4Ed.Core.Domain.Translations
{
    public class Culture : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}