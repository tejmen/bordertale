using System;

namespace bordertale
{
    internal class MainGame
    {
        public static int width = 28;

        public static void TitleScreen()
        {
            Console.WriteLine(" _______  _______  ______    ______   _______  ______    _______  _______  ___      _______ ");

            PrintUtils.GetHash(width);
            PrintUtils.PadHash("Welcome to Bordertale!", width);
            PrintUtils.PadHash("- Play -", width);
            PrintUtils.PadHash("- Resume -", width);
            PrintUtils.PadHash("- Help -", width);
            PrintUtils.PadHash("- Acknoledgements -", width);
            PrintUtils.PadHash("- Quit -", width);
            PrintUtils.PadHash("Copyright 2021 tejmen09", width);
            PrintUtils.GetHash(width);
        }
    }
}
