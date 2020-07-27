using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabLib
{
    public interface INamed
    {
        String Name { get; set; }
        String Code { get; set; }
        String Numeric { get; set; }
    }
}
