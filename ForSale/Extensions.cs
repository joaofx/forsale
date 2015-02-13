using System.Collections.Generic;
using System.Linq;

namespace ForSale
{
    public static class Extensions
    {
        public static IEnumerable<T[]> EachSlice<T>(this IEnumerable<T> xs, int size)
        {
            return xs.Select((x, i) => new { x, i })
                     .GroupBy(xi => xi.i / size, xi => xi.x)
                     .Select(g => g.ToArray());
        }
    }
}