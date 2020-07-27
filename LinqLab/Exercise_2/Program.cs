using LinqLabLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_2
{
    /// <summary>
    /// 2. Произвести операции соединения и группирования 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CDataProvider provider = new CDataProvider();

                var firstList = provider.GetNamesFromAToM();
                Console.WriteLine($"FirstList first element:{firstList.FirstOrDefault()} last element:{firstList.LastOrDefault()} length: {firstList.Count()}");
               
                var secondList = provider.GetNamesFromNToZ();
                Console.WriteLine($"SecondList first element:{secondList.FirstOrDefault()} last element:{secondList.LastOrDefault()} length: {secondList.Count()}");
               
                var fullList = CInteractor_2.GetConcatinate(firstList, secondList);
                var groupedList = CInteractor_2.GetGroupedByLastNumberOfCode(fullList);

                foreach (IGrouping<Char, INamed> keyGroupSequence in groupedList)
                {
                    Console.WriteLine($"\nCountries with codes that ends with: {keyGroupSequence.Key}\n");
                    foreach (INamed value in keyGroupSequence)
                        Console.WriteLine($"Country: {value}");
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
