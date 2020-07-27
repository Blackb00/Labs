using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLab;
using LinqLabLib;

namespace LinqLab.Excercise_4
{
    /// <summary>
    /// 
    ///4. Для выборки элементов (предполагая, что у каждого элемента есть имя Name)
    /// произвести конкатенацию имен всех элементов, кроме первых трех, в одну строку,
    /// разделенных заданным параметром (символом) delimeter
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
                Console.WriteLine("Original array:");
                IPersonable[] personable = CDataProvider.CreatePersons(arrayCount);
                foreach (var person in personable)
                {
                    Console.WriteLine(person);
                }

                Console.WriteLine($"\nResult string: {CInteractor.GetNamesConcatenated(personable)}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
