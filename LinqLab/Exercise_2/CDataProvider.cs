using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLabLib;

namespace LinqLab.Exercise_2
{
    class CDataProvider
    {
        static String _path = "./../../../LinqLabLib/Source/Countries.txt";
        List<INamed> _objects = CService.ReadFromTextFile(_path);
        internal IEnumerable<INamed> GetNamesFromAToM()
        {
            IEnumerable <INamed> names = CService.GetNamesFromATo('M', _objects);
            return names;
        }

        internal IEnumerable<INamed> GetNamesFromNToZ()
        {
            IEnumerable<INamed> names = CService.GetNamesToZFrom('N', _objects);
            return names;
        }
    }
}
