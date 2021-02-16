using bordertale.Entities;
using System;
using System.Threading;

namespace bordertale
{
    public class MainGame
    {
        public static Player player = new Player();
        public static void StartGame()
        {
            PrintUtils.SlowPrint("What is your name young traveller?");
            player.name = PrintUtils.Input();
            if (player.name == "dev")
            {
                player.name = "Developer";
                player.job = new Job("Fighter", 120, 40);
                player.SetJob();
                MainGameLoop();
            }
            PrintUtils.SlowPrint($"What is will your role be {player.name}?");
            Console.WriteLine("(You can be a Fighter, Wizard or healer)");
            bool inLoop = true;
            while (inLoop)
            {
                string playerJob = PrintUtils.Input().ToLower();
                switch (playerJob)
                {
                    case "fighter":
                        inLoop = false;
                        player.job = new Job("Fighter", 120, 40);
                        break;
                    case "wizard":
                        inLoop = false;
                        player.job = new Job("Healer", 200, 20, 40);
                        break;
                    case "healer":
                        inLoop = false;
                        player.job = new Job("Wizard", 300, 20, 20);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid role.");
                        break;
                }
            }
            player.SetJob();
            PrintUtils.SlowPrint($"Welcome {player.name} the {player.job.name}.");
            PrintUtils.SlowPrint("Welcome to this fanatasy world!", 30);
            PrintUtils.SlowPrint("Just dont get lost...", 100);
            PrintUtils.SlowPrint("(Cough, Cough)", 20);
            PrintUtils.GetHash(28);
            PrintUtils.CenterPadHash("Let's Jump In!", 28);
            PrintUtils.GetHash(28);
            MainGameLoop();
        }
        public static void MainGameLoop()
        {
            // @todo add Player.PrintLocation();
            while (!player.dead)
            {
                Prompt();
            }
        }

        public static void Prompt()
        {
            Console.WriteLine();
            PrintUtils.GetHash(31);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(You can 'move', 'quit', 'look', 'talk', 'equip', 'help', 'stats' or 'act' or 'mission')");
            bool inLoop = true;
            while (inLoop)
            {
                string action = PrintUtils.Input().ToLower();
                switch (action)
                {
                    case "quit":
                        inLoop = false;
                        PrintUtils.GetHash(15);
                        PrintUtils.CenterPadHash("GOODBYE!!", 15);
                        PrintUtils.GetHash(15);
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    case "move":
                        inLoop = false;
                        // @todo add Player.Move()
                        break;
                    case "look":
                        inLoop = false;
                        // @todo add Player.Examine()
                        break;
                    case "act":
                        inLoop = false;
                        // @todo add Player.Act()
                        break;
                    case "talk":
                        inLoop = false;
                        // @todo add Player.Talk()
                        break;
                    case "equip":
                        inLoop = false;
                        // @todo add Player.Equip()
                        break;
                    case "stats":
                        inLoop = false;
                        // @todo add Screens.Stats()
                        break;
                    case "help":
                        inLoop = false;
                        Screens.HelpScreen(true);
                        break;
                    case "mission":
                        inLoop = false;
                        // @todo add Player.Missions()
                        break;
                    case "money":
                        player.money = Convert.ToInt32(PrintUtils.Input("Money = ?"));
                        Console.WriteLine(player.money);
                        break;
                    default:
                        Console.WriteLine("Unknown action, try again.");
                        break;
                }
            }
        }
    }
}
