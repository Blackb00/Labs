using LinqLabLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab.Exercise_1
{
    /// <summary>
    /// 1. Произвести выборку, фильтрацию и упорядочение последовательности объектов, считанных/десериализованных из файла
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CDataProvider provider = new CDataProvider();
                List<INamed> objects = provider.GetData();

                Console.WriteLine("Original list\n");
                foreach (var value in objects)
                {
                    Console.WriteLine($"{value.Name} {value.Code} {value.Numeric}");
                }
                Console.WriteLine("\nResults\n");

                Console.WriteLine("Selected by name");

                IEnumerable<String> objects1 = CInteractor_1.SelectNames(objects);
                foreach (var value in objects1)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nSelected by code\n");

                IEnumerable<String> objects2 = CInteractor_1.SelectCodes(objects);
                foreach (var value in objects2)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nSelected by numeric\n");

                IEnumerable<String> objects3 = CInteractor_1.SelectNumerics(objects);
                foreach (var value in objects3)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nFiltered by Name Starts With Bra\n");

                IEnumerable<INamed> objects4 = CInteractor_1.GetFilteredByName(objects, "Bra");
                foreach (var value in objects4)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nOrdered by length of Name\n");

                IOrderedEnumerable<INamed> objects5 = CInteractor_1.GetOrderedByNameLength(objects);
                foreach (var value in objects5)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nOrdered by length of Name and Numeric code\n");

                IOrderedEnumerable<INamed> objects6 = CInteractor_1.GetOrderedByNameLengthAndNum(objects);
                foreach (var value in objects6)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("\nSelected by name, sorted by first letter A and ordered in reverse order\n");
                IEnumerable<String> objectsSorted = CInteractor_1.GetSelectedSortedOrdered(objects, "A");
                foreach (var value in objectsSorted)
                {
                    Console.WriteLine(value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
