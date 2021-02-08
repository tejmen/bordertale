using System;

namespace bordertale
{
    internal class MainGame
    {
        public static void TitleScreen()
        {
            int width = 28;
            Console.WriteLine(" _______  _______  ______    ______   _______  ______    _______  _______  ___      _______ ");
            PrintUtils.GetHash(width);
            PrintUtils.CenterPadHash("Welcome to Bordertale!", width);
            PrintUtils.CenterPadHash("- Play -", width);
            PrintUtils.CenterPadHash("- Resume -", width);
            PrintUtils.CenterPadHash("- Help -", width);
            PrintUtils.CenterPadHash("- Acknoledgements -", width);
            PrintUtils.CenterPadHash("- Quit -", width);
            PrintUtils.CenterPadHash("Copyright 2021 tejmen09", width);
            PrintUtils.GetHash(width);
        }
        public static void HelpScreen(bool inGame)
        {
            int width = 31;
            PrintUtils.GetHash(width);
            PrintUtils.CenterPadHash("Help", width);
            PrintUtils.LeftPadHash("", width);
        }
    }
}
