using LinqLabLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLab.Exercise_5;

namespace LinqLAb.Exercise_5
{
    /// <summary>
    ///
    /// 5. Найти все элементы в последовательности/выборке,
    /// длина имени (количество символов) у которых больше,
    /// чем позиция, которую они занимают в последовательности/выборке
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lets create an array to work with!");
                var arrayCount = CService.GetInt();

                var values = CDataProvider.CreateDifferentSizedValues(arrayCount);

                Console.WriteLine("Original array");
                foreach (var val in values)
                    Console.WriteLine(val);

                var result = CInteractor.GetValuesLengthExceedIndex(values);

                Console.WriteLine("Result");
                foreach (var val in result)
                    Console.WriteLine(val);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
