using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabLib
{
    public class CNamed
    {
        public String Name { get; set; }
        public String Code { get; set; }

        public override string ToString()
        {
            return $"{Name} {Code}";
        }
    }
}
