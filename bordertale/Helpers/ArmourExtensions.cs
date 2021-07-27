using System.Collections.Generic;
using bordertale.Articles;
namespace bordertale.Helpers
{
    public static class ArmourExtensions
    {
        public static IEnumerable<Armour> ToList(this IEnumerable<Item> items)
        {
            var list = new List<Armour>();

            foreach (var item in items)
            {
                if (item is Armour)
                {
                    list.Add((Armour)item);
                }
            }
            return list;
        }

    }
}