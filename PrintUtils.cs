using System.Linq;
using System.Text;

namespace bordertale
{
    class PrintUtils
    {
        public static string PadHash(string text, int length)
        {
            string finalString = '#' + text + '#';
            while (length > finalString.Length)
            {
                finalString = finalString.Insert(1, " ");
                if (length > finalString.Length)
                {
                    finalString = finalString.Insert(finalString.Length - 1, " ");
                }
            }

            return finalString;
        }
        
        public static string GetHash(int length)
        {
            var finalString = new string('#', length);
            return finalString.ToString();
        }
    }
}
