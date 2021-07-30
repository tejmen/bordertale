using bordertale.Articles;
using bordertale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bordertale.Helpers
{
    public static class CombatHandler
    {
        public static void Combat(Mob mob, Player player, bool skipForTesting = false)
        {
            if (mob.hp != mob.GetMax() && mob.effects != mob.originalEffects)
            {
                mob.Reset();
            }
            if (!skipForTesting)
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(mob.appear);
            Console.ResetColor();
            while (mob.hp > 0)
            {
                CombatRound(mob, player, skipForTesting);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mob.defeat);
            Console.ResetColor();
            player.xpChange(mob.xp);
            player.Pay(mob.money);
            int levels = (int)Math.Floor((float)player.xp / 1000);
            if (levels % 10 == 0)
            {
                player.ap += 1;
                PrintUtils.LeftBoxHash("You levelled up!", 20, ConsoleColor.Green);
            }
            List<Effects> effectsToRemove = new List<Effects>();
            foreach (Effects effect in player.effects)
            {
                effectsToRemove.Add(effect);
            }
            foreach (Effects effect in effectsToRemove)
            {
                player.effects.Remove(effect);
            }
        }

        private static void CombatRound(Mob mob, Player player, bool skipForTesting = false)
        {
            bool willDefend = false; // * Used for defending with shield
            var len = 88;
            PrintUtils.GetHash(len);
            PrintUtils.LeftPadHash("What would you like to do?", len);
            PrintUtils.LeftPadHash("(You can 'attack', or if you are a healer, you can 'heal')", len);
            if (player.inventory.OfType<Shield>().Any())
            {
                PrintUtils.LeftPadHash("(You own a shield! type 'defend' to (hopefully) protect you from the enemy's attack!", len);
            }
            PrintUtils.GetHash(len);
            bool inLoop = true;
            while (inLoop)
            {
                string choice;
                if (!skipForTesting)
                {
                    choice = PrintUtils.Input();
                }
                else
                {
                    choice = "attack";
                }
                switch (choice.ToLower().Trim())
                {
                    case "attack":
                        inLoop = false;
                        mob.Damage(player.ap + player.weapon.ap);
                        if (mob.hp < 0)
                        {
                            mob.hp = 0;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        PrintUtils.LeftPadHash($"The monster's health is {mob.hp}", $"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        Console.ResetColor();
                        break;
                    case "kill":
                        inLoop = false;
                        mob.hp = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        PrintUtils.LeftPadHash($"The monster's health is {mob.hp}", $"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length + 5, ConsoleColor.Green);
                        Console.ResetColor();
                        break;
                    case "heal":
                        inLoop = false;
                        if (player.job == JobFactory.CreateJob("healer"))
                        {
                            player.Heal();
                            Console.ForegroundColor = ConsoleColor.Green;
                            PrintUtils.SlowPrint($"You have {player.hp} health now.", 100, ConsoleColor.Cyan);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You can't heal. You're not a healer.");
                            Console.ResetColor();
                        }
                        break;
                    case "defend":
                        inLoop = false;
                        if (player.inventory.OfType<Shield>().Any())
                        {
                            int defends = new Random().Next(0, 10);
                            if (defends < 7)
                            {
                                willDefend = true;
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Your defence was successful, and the shield deflected the blow");
                                Console.ResetColor();
                            }
                            else
                            {
                                willDefend = false;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Unfortunately, your defence failed.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You don't have a shield. You can't defend.");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        Console.WriteLine("That wasn't a command. Try again.");
                        break;
                }
            }
            if (mob.hp > 0)
            {
                int damage = mob.ap;
                if (!willDefend)
                {
                    if (!(player.armour == null))
                    {
                        foreach (var item in player.armour)
                        {
                            damage -= (int)Math.Floor((float)item.dp / 2);
                            item.Degrade();
                        }
                        player.armour.RemoveAll(item => item.durability <= 0);
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mob.attack);
                    Console.ResetColor();
                    player.Damage(damage);
                    if (mob.effects != null)
                    {
                        List<Effects> effects = new();
                        foreach (Effects effect in mob.effects) // * Add Effects to Player
                        {
                            if (!player.effects.Contains(effect))
                            {
                                player.effects.Add(effect);
                            }
                            effects.Add(effect);
                        }
                        foreach (Effects effect in effects) // * Remove Effects from Mob
                        {
                            mob.effects.Remove(effect);
                        }
                        foreach (Effects effect in player.effects) // * Handle Player's current Effects
                        {
                            EffectsHandler.HandleEffect(player, effect);
                        }
                    }
                }
                if (player.hp <= 0)
                {
                    player.hp = 0;
                    player.dead = true;
                    Console.WriteLine(mob.kill);
                    Thread.Sleep(500);
                    MainGame.EndGame();
                }
                PrintUtils.SlowPrint($"You have {player.hp} health left.", 100);
            }
        }
    }
}
