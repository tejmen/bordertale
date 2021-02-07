using System;

namespace bordertale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintUtils.GetHash(28));
            Console.WriteLine(PrintUtils.PadHash("Welcome to Bordertale!", 28));
            Console.ReadKey();
        }
    }
}
