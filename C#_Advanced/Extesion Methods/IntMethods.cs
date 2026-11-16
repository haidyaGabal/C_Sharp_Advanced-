using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Extesion_Methods
{
    public static class IntMethods
    {
        public static bool ISEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
