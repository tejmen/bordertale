using bordertale.Articles;
using bordertale.Entities;
using bordertale.Helpers;
using System;
using System.Threading;

namespace bordertale
{
    public class MainGame
    {
        public static Player player = new();
        public static void StartGame()
        {
            PrintUtils.SlowPrint("What is your name young traveller?");
            player.name = PrintUtils.Input();
            if (player.name == "dev")
            {
                player.name = "Developer";
                player.job = new Articles.Job("Fighter", 120, 40, (Weapon)ItemFactory.CreateItem("sword"));
                player.SetJob();
                Map.PopulateLocation();
                // * Start Tab Autocompletion
                ReadLine.AutoCompletionHandler = new AutoCompletionHandler();
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
                        player.job = JobFactory.CreateJob("fighter");
                        break;
                    case "wizard":
                        inLoop = false;
                        player.job = JobFactory.CreateJob("wizard");
                        break;
                    case "healer":
                        inLoop = false;
                        player.job = JobFactory.CreateJob("healer");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid role.");
                        break;
                }
            }
            player.SetJob();
            Map.PopulateLocation();
            PrintUtils.SlowPrint($"Welcome {player.name} the {player.job.name}.");
            PrintUtils.SlowPrint("Welcome to this fantasy world!", 30);
            PrintUtils.SlowPrint("Just don't get lost...", 100);
            PrintUtils.SlowPrint("(Cough, Cough)", 20);
            PrintUtils.GetHash(28);
            PrintUtils.CenterPadHash("Let's Jump In!", 28);
            PrintUtils.GetHash(28);
            // * Start Tab Autocompletion
            ReadLine.AutoCompletionHandler = new AutoCompletionHandler();
            MainGameLoop();
        }
        public static void MainGameLoop()
        {

            player.PrintLocation();
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
                string[] words = action.Split(' ');
                switch (words[0])
                {
                    case "quit":
                        inLoop = false;
                        EndGame();
                        break;
                    case "look":
                        inLoop = false;
                        player.Examine();
                        break;
                    case "act":
                        inLoop = false;
                        player.Act();
                        break;
                    case "talk":
                        inLoop = false;
                        player.Talk();
                        break;
                    case "equip":
                        inLoop = false;
                        // @todo add Player.Equip()
                        break;
                    case "stats":
                        inLoop = false;
                        Screens.Stats();
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
                        inLoop = false;
                        player.money = Convert.ToInt32(PrintUtils.Input("Money = ?"));
                        Console.WriteLine(player.money);
                        break;
                    case "move":
                        inLoop = false;
                        if (words.Length == 2)
                        {
                            string direction = words[1];
                            player.Move(direction);
                        }
                        else if (words.Length == 3 && words[1] == "tp")
                        {
                            string destination = words[2];
                            player.Move(true, destination);
                        }
                        else
                        {
                            Console.WriteLine("\nPlease type where you want to go.");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown action, try again.");
                        break;
                }
            }
        }

        public static void EndGame()
        {
            PrintUtils.GetHash(15);
            PrintUtils.CenterPadHash("GOODBYE!!", 15);
            PrintUtils.GetHash(15);
            Thread.Sleep(500);
            Environment.Exit(0);
        }
    }
}
