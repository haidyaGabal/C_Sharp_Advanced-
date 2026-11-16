using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Extesion_Methods
{
    public static class StringMethods
    {
        public static int NumberOfWords(this string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return 0;

            return word.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            ).Length;
        }
    }
}
