using System;
using System.Collections.Generic;
using System.Linq;
using LinqLabLib;


namespace LinqLab.Exercise_3
{
    /// <summary>
    /// 3. Произвести объединение нескольких выборок с использованием:
    /// - join
    /// - union
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CDataProvider provider = new CDataProvider();

                var objectsNamed = provider.GetNamed();
                var objectsNumeric = provider.GetNumeric();
                var joinedObjects = CInteractor_3.GetJoined(objectsNamed, objectsNumeric);

                var objectsFromAToP = provider.GetObjectsFromAToP();
                var objectsFromHToZ = provider.GetObjectsFromHToZ();
                var unitedObjects = CInteractor_3.GetUnited(objectsFromAToP, objectsFromHToZ);

                Console.WriteLine("JOIN\nFirst collection: \n");
                foreach (var value in objectsNamed)
                    Console.WriteLine(value);

                Console.WriteLine("\nSecond collection\n");
                foreach (var value in objectsNumeric)
                    Console.WriteLine(value);

                Console.WriteLine("\nResult\n");
                foreach (var value in joinedObjects)
                    Console.WriteLine(value);

                Console.WriteLine($"\n\nUNION\nFirst collection: Count {objectsFromAToP.Count()}\n");
                foreach (var value in objectsFromAToP)
                    Console.WriteLine(value);

                Console.WriteLine($"\nSecond collection: Count {objectsFromHToZ.Count()}\n");
                foreach (var value in objectsFromHToZ)
                    Console.WriteLine(value);

                Console.WriteLine($"\nResult: Count {unitedObjects.Count()}\n");
                foreach (var value in unitedObjects)
                    Console.WriteLine(value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
