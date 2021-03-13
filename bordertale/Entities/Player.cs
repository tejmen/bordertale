using System;
using System.Reflection;

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
                Location destination = (Location) destlocation.GetValue(null);
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
            PrintUtils.LeftPadHash(this.location.examination,length);
            PrintUtils.GetHash(length);
        }

        public void Talk()
        {
            int length = 4 + this.location.dialogue.Length;
            PrintUtils.GetHash(length);
            PrintUtils.LeftPadHash(this.location.dialogue,length);
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

        public string name;
        public Job job;
        public int heal;
        public Location location;
        // @todo Add Effects Class
        // @todo Add Armour Class
        // @todo Add Shield Class
        public bool dead;
        // @todo Add Item Class
        // @todo Add Weapons Class
        // @todo Add Missions Class
    }
}
