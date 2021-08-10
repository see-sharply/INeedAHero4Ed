using System;
using System.Collections.Generic;
using System.Linq;

namespace INeedAHero4Ed.Core.Domain.Universe
{
    public enum AttributeType
    {
        WS,
        BS,
        S,
        T,
        I,
        Agi,
        Dex,
        Int,
        WP,
        Fel
    }

    public static class AttributeTypeExtensions
    {
        private const char Separator = ';';
        
        public static string ToDatabaseString(this IEnumerable<AttributeType> set) => string.Join(Separator, set);

        public static ISet<AttributeType> ToAttributeTypesSet(this string input) => 
            input
            .Split(Separator, StringSplitOptions.RemoveEmptyEntries)
            .Select(Enum.Parse<AttributeType>).ToHashSet();
    }
}