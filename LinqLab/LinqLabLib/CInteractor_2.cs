using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLabLib;

namespace LinqLabLib
{
    public class CInteractor_2
    {
        public static IEnumerable<T> GetConcatinate<T>(IEnumerable<T> firstList, IEnumerable<T> secondlist)
        {
            IEnumerable<T> fullList = firstList.Concat(secondlist);
            return fullList;
        }

        public static IEnumerable<IGrouping<Char, INamed>> GetGroupedByLastNumberOfCode(IEnumerable<INamed> objects)
        {
            var groupedObjects = objects.GroupBy(x =>(char) x.Numeric.LastOrDefault()).OrderBy(x=>x.Key);
            return groupedObjects;
        }
    }
}
