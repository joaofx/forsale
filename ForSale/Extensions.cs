﻿using System.Collections.Generic;
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

        public static string Show(this decimal value)
        {
            //// TODO: http://cbsa.com.br/post/usar-globalization-no-webconfig-e-cultureinfo-para-formatar-data-e-moeda-em-varios-idiomas-no-aspnet-c.aspx
            return string.Format("{0:C}", value);
        }
    }
}