using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public static class ExtensionMethods
    {
        ///1- Extension Methods
        ///Extension methods allow you to add new methods to existing types without modifying the original type,
        ///creating a new derived type, or recompiling.
        ///
        /// first you must static for class
        /// add this keyword for first parameter
        /// 

        public static bool checkNumberBetween(this int num,int first,int last)
        {
            return num >= first && num <= last;
        }

    }
}
