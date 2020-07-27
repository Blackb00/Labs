using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_5
{
    class CDataProvider
    {
        private static Random s_random = new Random();
        public static String[] CreateDifferentSizedValues(Int32 numberOfItems)
        {
            String[] diffSizedValues = new String[numberOfItems];
            for (var i = 0; i < numberOfItems; i++)
            {
                diffSizedValues[i] = new String(Enumerable.Repeat('a', s_random.Next(1, 20)).ToArray());
            }

            return diffSizedValues;
        }
    }
}
