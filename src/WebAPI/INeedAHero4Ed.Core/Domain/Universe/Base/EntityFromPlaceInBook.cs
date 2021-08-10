using INeedAHero4Ed.Core.Domain.Base;

namespace INeedAHero4Ed.Core.Domain.Universe.Base
{
    public abstract class EntityFromPlaceInBook : Entity
    {
        public PlaceInBook PlaceInBook { get; set; }
    }
}