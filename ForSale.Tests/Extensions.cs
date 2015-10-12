using System;
using System.Collections.Generic;
using System.Linq;

namespace ForSale.Tests
{
    public static class Extensions
    {
        public static long ToLong(this object value)
        {
            long ret = 0;

            if (value == null)
            {
                return ret;
            }

            long.TryParse(value.ToString(), out ret);
            return ret;
        }

        public static int ToInt(this object value)
        {
            int ret = 0;

            if (value == null)
            {
                return ret;
            }

            if (value.GetType().IsEnum)
            {
                return (int)value;
            }

            int.TryParse(value.ToString(), out ret);
            return ret;
        }

        public static DateTime ToDateTime(this string s)
        {
            DateTime dtr;
            var tryDtr = DateTime.TryParse(s, out dtr);
            return (tryDtr) ? dtr : new DateTime();
        }

        public static string With(this string s, params object[] parameters)
        {
            return string.Format(s, parameters);
        }

        public static string JoinTo<T>(this IEnumerable<T> enumerable, string split, Func<T, string> action)
        {
            return enumerable
                .Aggregate(string.Empty, (current, item) => current + (action(item) + split))
                .TrimEnd(split.ToCharArray());
        }

        public static bool IsBetween(this DateTime sourceDate, DateTime startDate, DateTime endDate, bool compareTime = false)
        {
            return compareTime ?
                sourceDate >= startDate && sourceDate <= endDate :
                sourceDate.Date >= startDate.Date && sourceDate.Date <= endDate.Date;
        }
    }
}