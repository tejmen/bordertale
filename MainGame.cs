using System;

namespace bordertale
{
    internal class MainGame
    {

        public static void TitleScreen()
        {
            int width = 28;

            Console.WriteLine(PrintUtils.GetHash(width));
            Console.WriteLine(PrintUtils.PadHash("Welcome to Bordertale!", width));
            Console.WriteLine(PrintUtils.PadHash("- Play -", width));
            Console.WriteLine(PrintUtils.PadHash("- Resume -", width));
            Console.WriteLine(PrintUtils.PadHash("- Help -", width));
            Console.WriteLine(PrintUtils.PadHash("- Acknoledgements -", width));
            Console.WriteLine(PrintUtils.PadHash("- Quit -", width));
            Console.WriteLine(PrintUtils.PadHash("Copyright 2019 tejmen09", width));
        }
    }
}