using LinqLabLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Exercise_7
{
    class CDictionary
    {
        private Dictionary<String, String> _dictionary;
        public CDictionary()
        {
            _dictionary = CService.ReadFromFileAsDictionary("./../../Dictionary.json");
        }
        public String Translate(String word)
        {
            return _dictionary[word];
        }
    }
}
