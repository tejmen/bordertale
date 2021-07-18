using System.Diagnostics;
using bordertale.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using bordertale.Helpers;

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

        public void SetJob()
        {
            this.hp = this.job.max;
            this.max = this.job.max;
            this.heal = this.job.heal;
            this.ap = this.job.ap;
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
                    if (this.location.up != null)
                    {
                        Location destination = this.location.up;
                        this.SetLocation(destination);
                    }
                    break;
                case "down":
                    if (this.location.down != null)
                    {
                        Location destination = this.location.down;
                        this.SetLocation(destination);
                    }
                    break;
                case "left":
                    if (this.location.left != null)
                    {
                        Location destination = this.location.left;
                        this.SetLocation(destination);
                    }
                    break;
                case "right":
                    if (this.location.right != null)
                    {
                        Location destination = this.location.right;
                        this.SetLocation(destination);
                    }
                    break;
                default:
                    Console.WriteLine("You have either reached the end of the map, or typed your command in wrong.");
                    break;
            }
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
                System.Diagnostics.Debug.WriteLine($"The field could not be found: {e}");
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
            var itemInList = this.inventory.Where(armourItem => armourItem == chosenItem);
            this.inventory.RemoveAll(armourItem => armourItem == chosenItem);
            return ArmourExtensions.ToList(itemInList);
        }

        public void Equip(Armour item)
        {
            // Removing already equipped armour
            foreach (Armour armourItem in this.armour)
            {
                if (armourItem.armourType == item.armourType)
                {
                    this.Acquire(armourItem);
                    this.armour.Remove(armourItem);
                    this.armour.Add(item);
                }
            }
            var itemsInList = this.RemoveArmourFromInventory((Armour)item);
            try
            {
                this.armour.AddRange(itemsInList.ToList());
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
