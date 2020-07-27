using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_5
{
    internal class CInteractor
    {
        internal static IEnumerable<String> GetValuesLengthExceedIndex(String[] values)
        {
            var result = values?.Where((v, i) => v.Length > i);
            return result;
        }
    }
}
