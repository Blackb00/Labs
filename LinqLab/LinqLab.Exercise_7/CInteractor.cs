using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_7
{
    class CInteractor
    {
        internal static IEnumerable<IGrouping<Int32,String>> BookCreate(String inputText, Int32 wordCount)
        {
            CDictionary dic = new CDictionary();
            String[] strArr = inputText.Split(' ').Select(x=>dic.Translate(x.ToUpper())).ToArray();

           var res = strArr.GroupBy(x => Array.IndexOf(strArr, x)/wordCount);
           return res;

        }
    }
}
