using System;
using System.Threading;

namespace bordertale
{
    internal class Screens
    {

        public static void HelpScreen(bool inGame)
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
            Thread.Sleep(500);
            if (inGame)
            {
                MainGame.MainGameLoop();
            }
            else {
                TitleScreen();
            }
        }
        public static void TitleScreen()
        {
            int width = 28;
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
                string option = PrintUtils.Input().ToLower();
                switch (option)
                {
                    case "play":
                        inLoop = false;
                        MainGame.StartGame();
                        break;
                    case "help":
                        inLoop = false;
                        HelpScreen(false);
                        break;
                    case "quit":
                        inLoop = false;
                        PrintUtils.GetHash(15);
                        PrintUtils.CenterPadHash("GOODBYE!!", 15);
                        PrintUtils.GetHash(15);
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    case "acknowledgements":
                        inLoop = false;
                        AcknowledgementsScreen();
                        break;
                    case "resume":
                        inLoop = false;
                        // TODO Add ResumeGame() Functionality, ideally from a json object stored through a file.
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command.");
                        break;

                }
            }
        }

        private static void AcknowledgementsScreen()
        {
            PrintUtils.GetHash(31);
            PrintUtils.CenterPadHash("Acknowledgements", 31);
            PrintUtils.CenterPadHash("Beta Tested by:", 31);
            PrintUtils.LeftPadHash("• appcreatorguy ", 31);
            PrintUtils.LeftPadHash("• tejmen09 ", 31);
            PrintUtils.LeftPadHash("Helped By:", 31);
            PrintUtils.LeftPadHash("• appcreatorguy", 31);
            PrintUtils.LeftPadHash("• tejmen09", 31);
            PrintUtils.CenterPadHash(" Copyright 2019 Tejas Mengle ", 31);
            PrintUtils.GetHash(31);
            TitleScreen();
        }

        public static void Stats()
        {
            int len = 66;
            PrintUtils.GetHash(len);
            PrintUtils.CenterPadHash("STATS", len);
            PrintUtils.LeftPadHash($"You are {MainGame.player.name} the {MainGame.player.job.name}. ", len);
            PrintUtils.LeftPadHash($"You have {MainGame.player.hp} hp.",len);
            PrintUtils.LeftPadHash($"You have {MainGame.player.xp} xp and you are at level {Convert.ToInt32(MainGame.player.xp/1000)}.",len);
            PrintUtils.LeftPadHash($"You have {MainGame.player.ap} strength.", len);
            PrintUtils.LeftPadHash($"You have ₴ {MainGame.player.money}", len);
            // @todo add rest of stats screen
          //  PrintUtils.LeftPadHash($"Your current weapon, the {} does {} of damage.", len);
          //  PrintUtils.LeftPadHash($"Your Inventory contains: , end=", len);
          //  PrintUtils.LeftPadHash($"You are wearing these pieces of armour: ', end=''", len);
            PrintUtils.GetHash(len);
        }
    }
}