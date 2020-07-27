using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_7
{
    /// <summary>
    /// 
    ///7. Пусть есть англо-русский словарь. Есть некоторый текст на английском языке
    /// (представлен в виде последовательности слов).
    /// Необходимо сверстать из этих предложений книгу на русском языке для плохо видящих так,
    /// что на одной странице книги помещается не более N слов и при этом каждое слово напечатано в верхнем регистре.
    /// Перевод необходимо осуществлять пословно без учета грамматики. Считается, что каждое слово имеет перевод в словаре.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String str = "This dog eats too much vegetables after lunch";
                var book = CInteractor.BookCreate(str, 3);
                foreach (var page in book)
                {
                    foreach (var word in page)
                        Console.Write (word + ' ');
                    Console.Write("\n");
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
