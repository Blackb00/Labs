using LinqLabLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_3
{
    class CDataProvider
    {
        static String _path = "./../../../LinqLabLib/Source/Countries.txt";
        List<INamed> _objects = CService.ReadFromTextFile(_path);

        internal IEnumerable<CNamed> GetNamed()
        {
            var namedObjects = _objects.Select(x => new CNamed()
            {
                Name = x.Name,
                Code = x.Code
            });
            return namedObjects;
        }

        internal IEnumerable<CNumeric> GetNumeric()
        {
            var numeredObjects = _objects.Select(x => new CNumeric()
            {
                Numeric = x.Numeric,
                Code = x.Code
            });
            return numeredObjects;
        }

        internal IEnumerable<INamed> GetObjectsFromAToP()
        {
            var result = CService.GetNamesFromATo('P', _objects);
            return result;
        }

        internal IEnumerable<INamed> GetObjectsFromHToZ()
        {
            var result = CService.GetNamesToZFrom('H', _objects);
            return result;
        }
    }
}
