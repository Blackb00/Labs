using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabLib
{
    public class CNumeric
    {
        public String Code { get; set; }
        public String Numeric { get; set; }

        public override string ToString()
        {
            return $"{Numeric} {Code}";
        }
    }
}
