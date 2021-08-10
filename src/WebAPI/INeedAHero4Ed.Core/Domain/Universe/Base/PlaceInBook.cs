using INeedAHero4Ed.Core.Domain.Base;

namespace INeedAHero4Ed.Core.Domain.Universe.Base
{
    public class PlaceInBook : Entity
    {
        public Book Book { get; set; }
        public ushort PageNumber { get; set; }
    }
}