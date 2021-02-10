using bordertale.Entities;
using System;

namespace bordertale
{
    public class MainGame
    {
        public static void StartGame()
        {
            Player player = new Player();
            PrintUtils.SlowPrint("What is your name young traveller?");
            player.name = PrintUtils.Input();
            if (player.name == "dev")
            {
                player.name = "Developer";
                player.job = new Job("Fighter", 120, 40);
                player.SetJob();
                //MainGameLoop();
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
            // @todo Add MainGameLoop()
            // @body Add the main game loop, which leads into game functionality.
        }
    }
}
