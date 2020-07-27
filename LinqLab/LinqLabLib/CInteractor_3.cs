using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLabLib;

namespace LinqLabLib
{
    public class CInteractor_3
    {
        public static IEnumerable<INamed> GetJoined(IEnumerable<CNamed> namedObjects, IEnumerable<CNumeric> numericObjects)
        {
            var result = namedObjects.Join(numericObjects, name => name.Code, num => num.Code, (name, num) => new CNamedImplementation()
            {
                Name = name.Name,
                Code = name.Code,
                Numeric = num.Numeric
            });
            return result;
        }

        public static IEnumerable<INamed> GetUnited(IEnumerable<INamed> firstCol, IEnumerable<INamed> secondCol)
        {
            var result = firstCol.Union(secondCol);
            return result;
        }
    }
}
