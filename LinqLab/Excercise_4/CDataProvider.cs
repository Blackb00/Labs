using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Excercise_4
{
    class CDataProvider
    {
        private static Random s_random = new Random();
        private class Person : IPersonable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return $"Name:{Name}, Age:{Age}";
            }
        }
        public static IPersonable[] CreatePersons(Int32 numberOfItems)
        {
            IPersonable[] personsArray = new IPersonable[numberOfItems];

            for (var i = 0; i < numberOfItems; i++)
            {
                personsArray[i] = new Person
                {
                    Name = $"Name{i}",
                    Age = s_random.Next(10, 70)
                };
            }
            return personsArray;
        }
    }
}
