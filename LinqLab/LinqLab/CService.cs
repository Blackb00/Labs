using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class CService
    {
        public static Int32 GetInt()
        {
            Console.WriteLine("Введите число:");
            Int32 count;
            if (!Int32.TryParse(Console.ReadLine(), out count))
                GetInt();
            return count;
        }
    }
}
