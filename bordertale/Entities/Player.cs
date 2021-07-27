using System.Diagnostics;
using bordertale.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using bordertale.Helpers;
using System.Security.Cryptography;

namespace bordertale.Entities
{
    public class Player : Entity
    {
        public Player()
        {
            this.name = "";
            this.hp = 0;
            this.max = 0;
            this.xp = 0;
            this.ap = 0;
            this.job = null;
            this.heal = 0;
            this.dead = false;
            this.money = 0;
            this.location = Map.b2;
            this.inventory = new List<Item>();
            this.weapon = null;
        }

        internal void xpChange(int xp)
        {
            this.xp += xp;
        }

        public void SetJob()
        {
            this.hp = this.job.max;
            this.max = this.job.max;
            this.heal = this.job.heal;
            this.ap = this.job.ap;
            this.weapon = this.job.weapon;
        }

        public void PrintLocation()
        {
            System.Console.WriteLine("");
            int length = 4 + this.location.description.Length;
            PrintUtils.GetHash(length);
            PrintUtils.LeftPadHash(this.location.zoneName, length);
            PrintUtils.LeftPadHash(this.location.description, length);
            PrintUtils.GetHash(length);
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                case "north":
                    if (this.location.up != null)
                    {
                        Location destination = this.location.up;
                        this.SetLocation(destination);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have reached the end of the map.");
                    }
                    break;
                case "down":
                case "south":
                    if (this.location.down != null)
                    {
                        Location destination = this.location.down;
                        this.SetLocation(destination);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have reached the end of the map.");
                    }
                    break;
                case "left":
                case "west":
                    if (this.location.left != null)
                    {
                        Location destination = this.location.left;
                        this.SetLocation(destination);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have reached the end of the map.");
                    }
                    break;
                case "right":
                case "east":
                    if (this.location.right != null)
                    {
                        Location destination = this.location.right;
                        this.SetLocation(destination);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have reached the end of the map.");
                    }
                    break;
                default:
                    Console.WriteLine("You have typed your command in wrong.");
                    break;
            }
        }

        internal void Heal()
        {
            this.HpChange(this.heal);
        }

        public void Move(bool tp, string location)
        {
            try
            {
                Type map = typeof(Map);
                FieldInfo destlocation = map.GetField(location);
                Location destination = (Location)destlocation.GetValue(null);
                this.SetLocation(destination);
            }
            catch (NullReferenceException e)
            {
                System.Diagnostics.Debug.WriteLine($"The field could not be found:\n {e}");
            }
        }

        public void SetLocation(Location destination)
        {
            Console.WriteLine($"\nYou have moved to {destination.zoneName}.");
            this.location = destination;
            this.PrintLocation();
        }

        public void Examine()
        {
            int length = 4 + this.location.examination.Length;
            PrintUtils.GetHash(length);
            PrintUtils.LeftPadHash(this.location.examination, length);
            PrintUtils.GetHash(length);
        }

        public void Talk()
        {
            int length = 4 + this.location.dialogue.Length;
            PrintUtils.GetHash(length);
            PrintUtils.LeftPadHash(this.location.dialogue, length);
            PrintUtils.GetHash(length);
        }

        public void Act()
        {
            if (this.location.act != null)
            {
                this.location.act();
            }
            else
            {
                if (this.location.act == null)
                {
                    Console.WriteLine("There's nothing to do here!");
                }
            }
        }

        public void Pay(int amount)
        {
            this.money += amount;
        }

        public void Acquire(Item item)
        {
            if (item != null)
            {
                this.inventory.Add(item);
            }
        }

        public void Remove(Item item)
        {
            this.inventory.Remove(item);
        }

        public IEnumerable<Armour> RemoveArmourFromInventory(Armour chosenItem)
        {
            var itemInList = ArmourExtensions.ToList(this.inventory.Where(armourItem => armourItem == chosenItem));
            this.inventory.RemoveAll(armourItem => armourItem == chosenItem);
            return itemInList;
        }

        public void Equip(Armour item)
        {
            // Removing already equipped armour
            if (this.armour != null)
            {
                List<Armour> armourToRemove = new();
                foreach (Armour armourItem in this.armour)
                {
                    if (armourItem.armourType == item.armourType)
                    {
                        this.Acquire(armourItem);
                        armourToRemove.Add(armourItem);
                    }
                }
                foreach (var armour in armourToRemove)
                {
                    this.armour.Remove(armour);
                }
                this.RemoveArmourFromInventory(item);
                this.armour.Add(item);
            }
            else
            {
                var itemsInList = this.RemoveArmourFromInventory((Armour)item);
                if (this.armour == null) // Generate Armour If this is the first item to be equipped
                {
                    this.armour = new List<Armour>();
                }
                foreach (var armour in itemsInList)
                {
                    this.armour.Add(armour);
                }
            }
        }
        public void Equip(Weapon item)
        {
            this.Remove(item);
            this.Acquire(this.weapon);
            this.weapon = (Weapon)item;
        }

        public string name;
        public Job job;
        public int heal;
        public Location location;
        // @todo Add Effects Class
        public List<Armour> armour;
        public Shield shield;
        public bool dead;
        public List<Item> inventory;
        public Weapon weapon;
        // @todo Add Missions Class
    }
}
