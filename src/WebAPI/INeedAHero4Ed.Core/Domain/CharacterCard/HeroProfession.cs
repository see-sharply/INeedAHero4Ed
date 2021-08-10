using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Universe;

namespace INeedAHero4Ed.Core.Domain.CharacterCard
{
    public class HeroProfession : Entity
    {
        public ProfessionClass Class { get; set; }
        public ProfessionLevel Level { get; set; }
        public Status Status => Level.Status;
    }
}