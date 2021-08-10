using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Translations;
using INeedAHero4Ed.Core.Domain.Universe;

namespace INeedAHero4Ed.Core.Domain.CharacterCard
{
    public class HeroAttribute
    {
        public HeroAttribute(AttributeType type, int baseValue, int developmentValue)
        {
            Type = type;
            BaseValue = baseValue;
            DevelopmentValue = developmentValue;
        }

        public LocalizationSet Name { get; set; }
        public AttributeType Type { get; }
        public int BaseValue { get; private set; }
        public int DevelopmentValue { get; private set; }
        public int ActualValue => BaseValue + DevelopmentValue;
        
        public override int GetHashCode()
        {
            return (int)Type;
        }
    }
}