using Internal;
using System;
using System.Threading;

namespace bordertale
{
    internal class Screens
    {

        public static void HelpScreen(bool inGame)
        {
            if (!inGame)
            {
                Console.Clear();
            }
            int width = 31;
            PrintUtils.GetHash(width, ConsoleColor.DarkBlue);
            PrintUtils.CenterPadHash("Help", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Type 'move' command to", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" move", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Type your commands to do", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" them", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Type 'look' to inspect", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" something", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Type 'act' to do what you", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" can on your place", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• If you find a Dungeon,", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" please help to excavate it", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Find more weapons hidden", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" in chests to kill monsters", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Go to the store to buy", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" armour", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash("• Equip your armour for", width, ConsoleColor.DarkBlue);
            PrintUtils.LeftPadHash(" extra protection.", width, ConsoleColor.DarkBlue);
            PrintUtils.CenterPadHash("Copyright 2019 tejmen09", width, ConsoleColor.DarkBlue);
            PrintUtils.GetHash(width, ConsoleColor.DarkBlue);
            switch (inGame)
            {
                case true:
                    MainGame.MainGameLoop();
                    break;
                default:
                    TitleScreen();
                    break;
            }
        }

        public static void HelpScreen(string command)
        {
            switch (command)
            {
                case "move":
                    int len = 52;
                    PrintUtils.GetHash(len, ConsoleColor.Magenta);
                    PrintUtils.CenterPadHash("Movement Help", len, ConsoleColor.Magenta);
                    PrintUtils.LeftPadHash("• Type 'move' and what direction you want to go", len, ConsoleColor.Magenta);
                    PrintUtils.GetHash(len, ConsoleColor.Magenta);
                    break;
                case "":
                default:
                    Console.WriteLine($"'{command}' is not a valid command.");
                    break;
            }
        }
        public static void TitleScreen()
        {
            int width = 28;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" _______  _______  ______    ______   _______  ______    _______  _______  ___      _______ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|  _    ||       ||    _ |  |      | |       ||    _ |  |       ||   _   ||   |    |       |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("| |_|   ||   _   ||   | ||  |  _    ||    ___||   | ||  |_     _||  |_|  ||   |    |    ___|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|       ||  | |  ||   |_||_ | | |   ||   |___ |   |_||_   |   |  |       ||   |    |   |___ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|  _   | |  |_|  ||    __  || |_|   ||    ___||    __  |  |   |  |       ||   |___ |    ___|");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("| |_|   ||       ||   |  | ||       ||   |___ |   |  | |  |   |  |   _   ||       ||   |___ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|_______||_______||___|  |_||______| |_______||___|  |_|  |___|  |__| |__||_______||_______|\n");
            Console.ResetColor();
            PrintUtils.GetHash(width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("Welcome to Bordertale!", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("- Play -", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("- Resume -", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("- Help -", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("- Acknowledgements -", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("- Quit -", width, ConsoleColor.Yellow);
            PrintUtils.CenterPadHash("Copyright 2021 tejmen09", width, ConsoleColor.Yellow);
            PrintUtils.GetHash(width, ConsoleColor.Yellow);

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
                        PrintUtils.GetHash(15, ConsoleColor.DarkYellow);
                        PrintUtils.CenterPadHash("GOODBYE!!", 15, ConsoleColor.DarkYellow);
                        PrintUtils.GetHash(15, ConsoleColor.DarkYellow);
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
            Console.Clear();
            PrintUtils.GetHash(31, ConsoleColor.Green);
            PrintUtils.CenterPadHash("Acknowledgements", 31, ConsoleColor.Green);
            PrintUtils.CenterPadHash("Beta Tested by:", 31, ConsoleColor.Green);
            PrintUtils.LeftPadHash("• appcreatorguy ", 31, ConsoleColor.Green);
            PrintUtils.LeftPadHash("• tejmen09 ", 31, ConsoleColor.Green);
            PrintUtils.LeftPadHash("Helped By:", 31, ConsoleColor.Green);
            PrintUtils.LeftPadHash("• appcreatorguy", 31, ConsoleColor.Green);
            PrintUtils.LeftPadHash("• tejmen09", 31, ConsoleColor.Green);
            PrintUtils.CenterPadHash(" Copyright 2019 Tejas Mengle ", 31, ConsoleColor.Green);
            PrintUtils.GetHash(31, ConsoleColor.Green);
            TitleScreen();
        }

        public static void Stats()
        {
            int len = 71;
            ConsoleColor color = ConsoleColor.Cyan;
            PrintUtils.GetHash(len, color);
            PrintUtils.CenterPadHash("STATS", len, color);
            PrintUtils.LeftPadHash($"You are {MainGame.player.name} the {MainGame.player.job.name}. ", len, color);
            PrintUtils.LeftPadHash($"You have {MainGame.player.hp} hp.", len, color);
            PrintUtils.LeftPadHash($"You have {MainGame.player.xp} xp and you are at level {Convert.ToInt32(MainGame.player.xp / 1000)}.", len, color);
            PrintUtils.LeftPadHash($"You have {MainGame.player.ap} strength.", len, color);
            PrintUtils.LeftPadHash($"You have ₴ {MainGame.player.money}", len, color);
            PrintUtils.LeftPadHash($"Your current weapon, the {MainGame.player.weapon.name} does {MainGame.player.weapon.ap} of damage.", len, color);
            String inventory = "Your Inventory contains: ";
            if (MainGame.player.inventory != null)
            {
                foreach (var item in MainGame.player.inventory)
                {
                    inventory += item.name;
                }
            }
            PrintUtils.LeftPadHash(inventory, len, color);
            String armour = "You are wearing these pieces of armour: ";
            if (MainGame.player.armour != null)
            {
                foreach (var item in MainGame.player.armour)
                {
                    armour += item.name;
                }
            }
            PrintUtils.LeftPadHash(armour, len, color);
            PrintUtils.GetHash(len, color);
        }
        public static void ShopScreen()
        {
            PrintUtils.GetHash(103, ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(PrintUtils.CenterPadHashReturn("SHOP", 103));
            Console.WriteLine($@"
#                            #        ████████████████       #       ██████████████████████████       #
#      ██████    ██████      #      ██              ▒▒██     #     ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██     #
#    ██  ▒▒██    ██  ▒▒██    #      ██              ▒▒██     #     ██▒▒                      ▒▒██     #
#    ██  ▒▒██    ██  ▒▒██    #      ██    ▒▒▒▒▒▒▒▒  ▒▒██     #     ██▒▒                      ▒▒██     #
#    ██  ▒▒██    ██  ▒▒██    #      ██  ▒▒▒▒████▒▒  ▒▒██     #     ██▒▒                      ▒▒██     #
#  ██    ▒▒██    ██      ██  #      ██  ▒▒██    ██  ▒▒██     #     ██▒▒                      ▒▒██     #
#██    ▒▒▒▒██    ██▒▒    ▒▒██#      ██  ▒▒██    ██  ▒▒██     #     ██▒▒                      ▒▒██     #
#██▒▒▒▒▒▒██        ██▒▒▒▒▒▒██#      ██  ▒▒██    ██  ▒▒██     #     ██▒▒                      ▒▒██     #
#████████            ████████#      ██▒▒▒▒██    ██▒▒▒▒██     #     ██▒▒                      ▒▒██     #
#                            #      ████████    ████████     #     ██▒▒          ██          ▒▒██     #
#   [1]Boots        ₴ 10     #  [2]Leggings     ₴ 20         #     ██▒▒        ██████        ▒▒██     #
##############################################################     ██▒▒          ██          ▒▒██     #
#                            #       ████        ████        #     ██▒▒                      ▒▒██     #
#                            #   ████  ▒▒██    ██    ████    #     ██▒▒                      ▒▒██     #
#       ████████████         # ██      ▒▒██    ██      ▒▒██  #     ██▒▒                      ▒▒██     #
#     ██          ▒▒██       # ██          ████        ▒▒██  #     ██▒▒                      ▒▒██     #
#   ██            ▒▒▒▒██     # ██▒▒                  ▒▒▒▒██  #     ██▒▒                      ▒▒██     #
#   ██          ▒▒▒▒▒▒██     #   ██                ▒▒▒▒██    #       ██▒▒                  ▒▒██       #
#   ██    ████████▒▒▒▒██     #   ██▒▒              ▒▒▒▒██    #         ██▒▒              ▒▒██         #
#   ██  ████████████▒▒██     #     ██              ▒▒██      #           ██▒▒          ▒▒██           #
#   ██  ████████████▒▒██     #     ██            ▒▒▒▒██      #             ██▒▒▒▒▒▒▒▒▒▒██             #
#     ████        ████       #     ██▒▒        ▒▒▒▒▒▒██      #               ██▒▒▒▒▒▒██               #
#                            #     ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██      #                 ██▒▒██                 #
#                            #       ██▒▒▒▒▒▒▒▒▒▒▒▒██        #                   ██                   #
#                            #         ████████████          #                                        #
#                            #                               #                                        #
#    [3]Helmet      ₴ 30     #      [4]Chestplate ₴ 40       #     [5]Shield     ₴ 35                 #");
            PrintUtils.GetHash(103);
            PrintUtils.CenterPadHash("Type the number of the you want to buy to purchase. Type back to go back.", 103);
            PrintUtils.CenterPadHash($"You have ₴{MainGame.player.money.ToString()}.", 103);
            PrintUtils.GetHash(103);
            bool inLoop = true;
            while (inLoop)
            {
                string cart = PrintUtils.Input().ToLower();
                switch (cart)
                {
                    case "1":
                        inLoop = false;
                        MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("boots"));
                        break;
                    case "2":
                        inLoop = false;
                        MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("leggings"));
                        break;
                    case "3":
                        inLoop = false;
                        MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("helmet"));
                        break;
                    case "4":
                        inLoop = false;
                        MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("chestplate"));
                        break;
                    case "5":
                        inLoop = false;
                        MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("shield"));
                        break;
                    case "back":
                        inLoop = false;
                        MainGame.Prompt();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }
        }
    }
}