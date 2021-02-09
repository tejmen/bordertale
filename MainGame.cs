using System;
using System.Threading;

namespace bordertale
{
    internal class MainGame
    {
        public static void TitleScreen()
        {
            int width = 28;
            Console.WriteLine(" _______  _______  ______    ______   _______  ______    _______  _______  ___      _______ ");
            Console.WriteLine("|  _    ||       ||    _ |  |      | |       ||    _ |  |       ||   _   ||   |    |       |");
            Console.WriteLine("| |_|   ||   _   ||   | ||  |  _    ||    ___||   | ||  |_     _||  |_|  ||   |    |    ___|");
            Console.WriteLine("|       ||  | |  ||   |_||_ | | |   ||   |___ |   |_||_   |   |  |       ||   |    |   |___ ");
            Console.WriteLine("|  _   | |  |_|  ||    __  || |_|   ||    ___||    __  |  |   |  |       ||   |___ |    ___|");
            Console.WriteLine("| |_|   ||       ||   |  | ||       ||   |___ |   |  | |  |   |  |   _   ||       ||   |___ ");
            Console.WriteLine("|_______||_______||___|  |_||______| |_______||___|  |_|  |___|  |__| |__||_______||_______|\n");
            PrintUtils.GetHash(width);
            PrintUtils.CenterPadHash("Welcome to Bordertale!", width);
            PrintUtils.CenterPadHash("- Play -", width);
            PrintUtils.CenterPadHash("- Resume -", width);
            PrintUtils.CenterPadHash("- Help -", width);
            PrintUtils.CenterPadHash("- Acknoledgements -", width);
            PrintUtils.CenterPadHash("- Quit -", width);
            PrintUtils.CenterPadHash("Copyright 2021 tejmen09", width);
            PrintUtils.GetHash(width);
            bool inLoop = true;
            while (inLoop)
            {
                Console.Write("> ");
                string option = Console.ReadLine().ToLower().Trim();
                switch (option)
                {
                    case "play":
                        inLoop = false;
                        break;
                    // @todo StartGame Function
                    case "help":
                        inLoop = false;
                        HelpScreen();
                        break;
                    case "quit":
                        inLoop = false;
                        PrintUtils.GetHash(15);
                        PrintUtils.CenterPadHash("GOODBYE!!", 15);
                        PrintUtils.GetHash(15);
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    // @todo Create QuitGame
                    case "acknowledgements":
                        inLoop = false;
                        break;
                    // @todo AcknoledgeScreen() Placeholder Untill Writen
                    case "resume":
                        inLoop = false;
                        break;
                    // @todo ResumeGame from save File
                    default:
                        Console.WriteLine("Please enter a valid command.");
                        break;

                }
            }
        }
        public static void HelpScreen()
        {
            int width = 31;
            PrintUtils.GetHash(width);
            PrintUtils.CenterPadHash("Help", width);
            PrintUtils.LeftPadHash("• Type 'move' command to", width);
            PrintUtils.LeftPadHash(" move", width);
            PrintUtils.LeftPadHash("• Type your commands to do", width);
            PrintUtils.LeftPadHash(" them", width);
            PrintUtils.LeftPadHash("• Type 'look' to inspect", width);
            PrintUtils.LeftPadHash(" something", width);
            PrintUtils.LeftPadHash("• Type 'act' to do what you", width);
            PrintUtils.LeftPadHash("can on your place", width);
            PrintUtils.LeftPadHash("• If you find a Dungeon,", width);
            PrintUtils.LeftPadHash(" please help to excavate it", width);
            PrintUtils.LeftPadHash("• Find more weapons hidden", width);
            PrintUtils.LeftPadHash(" in chests to kill monsters", width);
            PrintUtils.LeftPadHash("• Go to the store to buy", width);
            PrintUtils.LeftPadHash(" armour", width);
            PrintUtils.LeftPadHash("• Equip your armour for", width);
            PrintUtils.LeftPadHash(" extra protection.", width);
            PrintUtils.CenterPadHash("Copyright 2019 tejmen09", width);
            PrintUtils.GetHash(width);
            TitleScreen();
        }
    }
}
