using System.Collections.Generic;
using System.Linq;

namespace PokerKata
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> collection, int numberOfItems)
        {
            return collection.Reverse().Take(numberOfItems).Reverse();
        }
    }
}
