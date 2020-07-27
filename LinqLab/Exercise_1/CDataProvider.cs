using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LinqLabLib;

namespace LinqLab.Exercise_1
{
    class CDataProvider
    {
        public List<INamed> GetData()
        {
            var path = "./../../../LinqLabLib/Source/Countries.txt";
            List<INamed> objects = CService.ReadFromTextFile(path);
            return objects;
        }

    }
}
