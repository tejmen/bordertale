using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale
{
    class PrintUtils
    {
        public static string PrintHash(string text)
        {
            string finalString = '#' + text + '#';
            finalString = finalString.Insert(1, " ");
            finalString = finalString.Insert(finalString.Length - 1, " ");
            return finalString;
        }
    }
}
