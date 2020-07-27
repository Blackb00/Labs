using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLabLib
{
    public class CInteractor_1
    {
        public static IEnumerable<String> SelectNames(List<INamed> objects)
        {
            IEnumerable<String> objectsSorted = objects.Select(x => x.Name);
            return objectsSorted;
        }
        public static IEnumerable<String> SelectCodes(List<INamed> objects)
        {
            IEnumerable<String> objectsSorted = objects.Select(x => x.Code);
            return objectsSorted;
        }
        public static IEnumerable<String> SelectNumerics(List<INamed> objects)
        {
            IEnumerable<String> objectsSorted = objects.Select(x => x.Numeric);
            return objectsSorted;
        }
        public static IEnumerable<INamed> GetFilteredByName(List<INamed> objects, String filterString)
        {
            IEnumerable<INamed> objectsSorted = objects.Where(x => x.Name.ToUpperInvariant().StartsWith((filterString.ToUpperInvariant())));
            return objectsSorted;
        }
        public static IOrderedEnumerable<INamed> GetOrderedByNameLength(List<INamed> objects)
        {
            IOrderedEnumerable<INamed> objectsSorted = objects.OrderBy(x => x.Name.Length);
            return objectsSorted;
        }
        public static IOrderedEnumerable<INamed> GetOrderedByNameLengthAndNum(List<INamed> objects)
        {
            IOrderedEnumerable<INamed> objectsSorted = objects.OrderBy(x => x.Name.Length).ThenBy((x => x.Numeric));
            return objectsSorted;
        }
        public static IEnumerable<String> GetSelectedSortedOrdered(List<INamed> objects, String filterStr)
        {
            IEnumerable<String> objectsSorted = objects.Select(x => x.Name).Where(y => y.ToUpperInvariant().StartsWith(filterStr.ToUpperInvariant())).OrderByDescending(x=>x);
            return objectsSorted;
        }
    }
}
