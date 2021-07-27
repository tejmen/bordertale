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
            Console.WriteLine(mob.appear);
            while (mob.hp > 0)
            {
                CombatRound(mob, player, skipForTesting);
            }
            Console.WriteLine(mob.defeat);
            player.xpChange(mob.xp);
            player.Pay(mob.money);
            int levels = (int)Math.Floor((float)player.xp / 1000);
            if (levels % 10 == 0)
            {
                player.ap += 1;
                PrintUtils.GetHash(20);
                PrintUtils.LeftPadHash("You levelled up!", 20);
                PrintUtils.GetHash(20);
            }
        }

        private static void CombatRound(Mob mob, Player player,  bool skipForTesting = false)
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
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length);
                        PrintUtils.LeftPadHash($"The monster's health is {mob.hp}", $"The monster's health is {mob.hp}".Length);
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length);
                        break;
                    case "kill":
                        inLoop = false;
                        mob.hp = 0;
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length);
                        PrintUtils.LeftPadHash($"The monster's health is {mob.hp}", $"The monster's health is {mob.hp}".Length);
                        PrintUtils.GetHash($"The monster's health is {mob.hp}".Length);
                        break;
                    case "heal":
                        inLoop = false;
                        if (player.job == JobFactory.CreateJob("healer"))
                        {
                            player.Heal();
                            PrintUtils.SlowPrint($"You have {player.hp} health now.", 100);
                        }
                        else
                        {
                            Console.WriteLine("You can't heal. You're not a healer.");
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
                                Console.WriteLine("Your defence was successful, and the shield deflected the blow");
                            }
                            else
                            {
                                willDefend = false;
                                Console.WriteLine("Unfortunately, your defence failed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have a shield. You can't defend.");
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
                    player.HpChange(-damage);
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
