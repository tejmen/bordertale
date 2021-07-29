using Internal;
using System.Globalization;
using System.Net.Mime;
using System;
using System.Threading;

namespace bordertale
{
    public class PrintUtils
    {
        /// <summary>
        /// Writes center-aligned string with hashes on either side
        /// </summary>
        /// <param name="text">String to center-align</param>
        /// <param name="length">Final length of string, including hashes</param>
        /// <param name="color">Foreground color to print</param>
        public static void CenterPadHash(string text, int length, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            if (text == null)
                throw new ArgumentNullException();

            if (text.Trim() == string.Empty)
                throw new ArgumentException(message: "'text' must be a valid, non-empty string!");

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
            Console.ResetColor();
        }

        /// <summary>
        /// Writes a string of hashes with a given length
        /// </summary>
        /// <param name="length">Final length of hashes</par>
        /// <param name="color">Foreground color to print</param>
        public static void GetHash(int length, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            var finalString = new string('#', length);
            Console.WriteLine(finalString.ToString());
            Console.ResetColor();
        }

        /// <summary>
        /// Writes left-aligned string with hashes on either side
        /// </summary>
        /// <param name="text">String to left-align</param>
        /// <param name="length">Final length of string, including hashes</param>
        /// <param name="color">Foreground color to print</param>
        public static void LeftPadHash(string text, int length, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            if (text == null)
                throw new ArgumentNullException();

            if (text.Trim() == string.Empty)
                throw new ArgumentException(message: "'text' must be a valid, non-empty string!");

            string finalString = text.PadRight(length - 3);
            finalString = "# " + finalString + '#';
            Console.WriteLine(finalString);
            Console.ResetColor();
        }

        /// <summary>
        /// Returns a center-aligned string with hashes on either side
        /// </summary>
        /// <param name="text">String to center-align</param>
        /// <param name="length">Final length of string, including hashes</param>
        /// <returns>Left-aligned string</returns>
        public static string CenterPadHashReturn(string text, int length)
        {
            if (text == null)
                throw new ArgumentNullException();

            if (text.Trim() == string.Empty)
                throw new ArgumentException(message: "'text' must be a valid, non-empty string!");

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

        /// <summary>
        /// Returns a string of hashes with a given length
        /// </summary>
        /// <param name="length">Final length of string</param>
        /// <returns>String of hashes</returns>
        public static string GetHashReturn(int length)
        {
            var finalString = new string('#', length);
            return finalString.ToString();
        }

        /// <summary>
        /// Returns a left-aligned string with hashes on either side
        /// </summary>
        /// <param name="text">String to left-align</param>
        /// <param name="length">Final length of string, including hashes</param>
        /// <returns>Left-aligned string with hashes on either side</returns>
        public static string LeftPadHashReturn(string text, int length)
        {
            if (text == null)
                throw new ArgumentNullException();

            if (text.Trim() == string.Empty)
                throw new ArgumentException(message: "'text' must be a valid, non-empty string!");

            string finalString = text.PadRight(length - 3);
            finalString = "# " + finalString + '#';
            return finalString;
        }

        /// <summary>
        /// Writes a string, one character at a time
        /// </summary>
        /// <param name="text">String to print</param>
        /// <param name="delayInMilliseconds">Delay per character</param>
        /// <param name="color">Foreground color to print</param>
        public static void SlowPrint(string text, int delayInMilliseconds = 50, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            foreach (char x in text)
            {
                Console.Write(x);
                Thread.Sleep(delayInMilliseconds);
            }
            Console.Write("\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Combination of GetHash and CenterPadHash to create a box
        /// </summary>
        /// <param name="text">String to center-align</param>
        /// <param name="length">Final width of box</param>
        /// <param name="color">Foreground color to print</param>
        public static void CenterBoxHash(string text, int length, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            PrintUtils.GetHash(length, color);
            PrintUtils.CenterPadHash(text, length, color);
            PrintUtils.GetHash(length, color);
            Console.ResetColor();
        }

        /// <summary>
        /// Returns a combination of GetHash and CenterPadHash to create a box
        /// </summary>
        /// <param name="text">String to center-align</param>
        /// <param name="length">Final width of box</param>
        /// <returns></returns>
        public static string CenterBoxHashReturn(string text, int length)
        {
            var finalString = PrintUtils.GetHashReturn(length);
            finalString += PrintUtils.CenterPadHashReturn(text, length);
            finalString += PrintUtils.GetHashReturn(length);
            return finalString;
        }

        /// <summary>
        /// Combination of GetHash and LeftPadHash to create a box
        /// </summary>
        /// <param name="text">String to left-align</param>
        /// <param name="length">Final width of box</param>
        /// <param name="color">Foreground color to print</param>
        public static void LeftBoxHash(string text, int length, ConsoleColor color = ConsoleColor.Gray)
        {
            if (color != ConsoleColor.Gray && Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = color;
            }
            PrintUtils.GetHash(length, color);
            PrintUtils.LeftPadHash(text, length, color);
            PrintUtils.GetHash(length, color);
            Console.ResetColor();
        }

        /// <summary>
        /// Returns a combination of GetHash and LeftPadHash
        /// </summary>
        /// <param name="text">String to left-align</param>
        /// <param name="length">Final width of box</param>
        /// <returns></returns>
        public static string LeftBoxHashReturn(string text, int length)
        {
            var finalString = PrintUtils.GetHashReturn(length);
            finalString += PrintUtils.LeftPadHashReturn(text, length);
            finalString += PrintUtils.GetHashReturn(length);
            return finalString;
        }

        /// <summary>
        /// Takes input from the console
        /// </summary>
        /// <param name="prompt">String to use as a prompt</param>
        /// <returns>Input from the console</returns>
        public static string Input(string prompt = ">")
        {
            if (prompt == null)
                throw new ArgumentNullException();

            if (prompt.Trim() == string.Empty)
                throw new ArgumentException(message: "'text' must be a valid, non-empty string!");

            // Console.Write($"{prompt} ");
            // String input = Console.ReadLine().Trim();
            String input = ReadLine.Read($"{prompt} ");
            return input;
        }
    }
}
