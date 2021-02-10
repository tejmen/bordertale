using System;

namespace bordertale
{
    class PrintUtils
    {
        public static void CenterPadHash(string text, int length)
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

            Console.WriteLine(finalString);
        }

        public static void GetHash(int length)
        {
            var finalString = new string('#', length);
            Console.WriteLine(finalString.ToString());
        }
        public static void LeftPadHash(string text, int length)
        {
            string finalString = text.PadRight(length - 3);
            finalString = "# " + finalString + '#';
            Console.WriteLine(finalString);
        }
        public static string CenterPadHashReturn(string text, int length)
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
        public static string GetHashReturn(int length)
        {
            var finalString = new string('#', length);
            return finalString.ToString();
        }
        public static string LeftPadHashReturn(string text, int length)
        {
            string finalString = text.PadRight(length - 3);
            finalString = "# " + finalString + '#';
            return finalString;
        }
    }
}
