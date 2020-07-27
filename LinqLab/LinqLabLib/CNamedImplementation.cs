

using System;

namespace LinqLabLib
{
    public class CNamedImplementation: INamed
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String Numeric { get; set; }

        public override string ToString()
        {
            return $"{Name} {Code} {Numeric}";
        }
    }
}
