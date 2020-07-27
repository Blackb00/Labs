using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Excercise_4
{
    internal class CInteractor
    {
        private static readonly char s_delimeter = '/';

        public static String GetNamesConcatenated(IPersonable[] persons)
        {
            String namesInString = String.Empty;
            try
            {
                namesInString = persons.Skip(3)
                    .Select(p => p.Name)
                    .Aggregate((av, e) => av + s_delimeter + e);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return namesInString;
        }
    }
}
