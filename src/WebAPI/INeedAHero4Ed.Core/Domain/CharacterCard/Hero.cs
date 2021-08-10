using System.Collections.Generic;
using INeedAHero4Ed.Core.Domain.Base;
using INeedAHero4Ed.Core.Domain.Universe;

namespace INeedAHero4Ed.Core.Domain.CharacterCard
{
    public class Hero : Entity
    {
        public Hero()
        {
            Attributes = new HashSet<HeroAttribute>();
            Skills = new HashSet<Skill>();
            Talents = new HashSet<Talent>();
        }
        
        public string Name { get; set; }
        public Race Race { get; set; }
        public HeroProfession Profession { get; set; }
        public Status Status => Profession.Status;
        public long Age { get; set; }
        public ushort Height { get; set; }
        public string Hair { get; set; }
        public string EyesColor { get; set; }

        public string Motivation { get; set; }

        public int HeroPoints { get; set; }
        public int DeterminationPoints { get; set; }
        public int DestinyPoints  { get; set; }
        public int LuckPoints  { get; set; }

        public int Experience { get; set; }

        public ISet<HeroAttribute> Attributes { get; }
        public ISet<Skill> Skills { get; }
        public ISet<Talent> Talents { get; }
        
    }
}