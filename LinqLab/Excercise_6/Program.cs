using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Excercise_6
{
    /// <summary>
    ///
    /// 6. Для заданного предложения сгруппировать слова одинаковой длины,
    /// отсортировать группы по убыванию количества элементов в каждой группе,
    /// вывести информацию по каждой группе: длина (количество букв в словах группы),
    /// количество элементов. Знаки препинания не учитывать.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";

                var arr = str.Split(' ');
                var newArr = new List<String>();
                foreach (var value in arr)
                {
                    var newValue = value.Trim(new char[] { ' ', ',', '-', '.', ':' });
                    newArr.Add(newValue);
                }

                var result = newArr.GroupBy(x => x.Length).OrderByDescending(y => y.Count());
               // var result = newArr.GroupBy(x => x.Length).OrderByDescending(x=>x.Count()).ThenByDescending(y => y.Key);
                foreach (IGrouping<Int32, String> keyGroupSequence in result)
                {
                    Console.WriteLine($"Длина слов: {keyGroupSequence.Key}. Количество слов: {keyGroupSequence.Count()}");
                    foreach (var value in keyGroupSequence)
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
