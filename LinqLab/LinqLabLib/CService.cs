using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace LinqLabLib
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

        public static Object[] ReadFromFile(string path)                      
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Object[] data = null;
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    try
                    {
                        data = (object[])formatter.Deserialize(fs);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("CService.ReadFromFile method", e);
                    }
                }
            }
            else
            {
                Console.WriteLine("target file doesn't exists");
            }
            return data;
        }
        public static List<INamed> ReadFromTextFile(string path)
        {
            List<INamed> objects = new List<INamed>();
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        String ln;
                        while ((ln = sr.ReadLine()) != null)
                        {
                            String[] arr = ln.Split(' ');
                            List<String> arr2 = new List<String>();
                            foreach (var s in arr)
                            {
                                if (s != "")
                                    arr2.Add(s);
                            }

                            StringBuilder str = new StringBuilder();
                            for (var i = 0; i < arr2.Count - 3; i++)
                            {
                                str.AppendFormat(arr2[i]);
                                if(i!=arr2.Count-4)
                                    str.AppendFormat(" ");
                            }

                            objects.Add(new CNamedImplementation()
                            {
                                Name = str.ToString(),
                                Code = arr2[arr2.Count - 2],
                                Numeric = arr2[arr2.Count - 1]
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("CService.ReadFromTextFile method", e);
                }
            }
            else
            {
                Console.WriteLine("target file doesn't exists");
            }
            return objects;
        }

        public static Dictionary<String, String> ReadFromFileAsDictionary(string path)
        {

            Dictionary<String, String> data = new Dictionary<string, string>();
            if (File.Exists(path))
            {
                try
                {
                    String jsonString = File.ReadAllText(path);
                    data = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                }
                catch (Exception e)
                {
                    throw new Exception("CService.ReadFromFile method", e);
                }
            }
            else
            {
                Console.WriteLine("target file doesn't exists");
            }
            return data;
        }

        public static IEnumerable<INamed> GetNamesFromATo(Char ch, List<INamed> objects)
        {
            IEnumerable<INamed> names = objects.Where(x => x.Name[0].CompareTo(ch) <= 0);
            return names;
        }

        public static IEnumerable<INamed> GetNamesToZFrom(Char ch, List<INamed> objects)
        {
            IEnumerable<INamed> names = objects.Where(x=> x.Name[0].CompareTo(ch)>=0);
            return names;
        }

    }
}
