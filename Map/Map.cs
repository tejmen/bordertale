using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Reflection;
using System;
using bordertale.Entities;

namespace bordertale
{
    public class Location
    {
        public void Populate(string zoneName, string description, string examination,
            Location up, Location down, Location left, Location right,
            string dialogue = "Theres nobody to talk to here...",
            Action action = null, bool solved = false)
        {
            this.zoneName = zoneName;
            this.description = description;
            this.examination = examination;
            this.dialogue = dialogue;
            this.solved = solved;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            this.act = action;
        }
        public string zoneName;
        public string description;
        public string examination;
        public bool solved;
        public Location up;
        public Location down;
        public Location left;
        public Location right;
        public string dialogue;

        public Action act;
    }

    public static class Map
    {
        // Instantiation of Locations
        public static Location a1 = new Location();
        public static Location a2 = new Location();
        public static Location a3 = new Location();
        public static Location a4 = new Location();
        public static Location b1 = new Location();
        public static Location b2 = new Location();
        public static Location b3 = new Location();
        public static Location b4 = new Location();
        public static Location c1 = new Location();
        public static Location c2 = new Location();
        public static Location c3 = new Location();
        public static Location c4 = new Location();
        public static Location d1 = new Location();
        public static Location d2 = new Location();
        public static Location d3 = new Location();
        public static Location d4 = new Location();
        // Population of Locations
        public static void PopulateLocation()
        {
            a1.Populate(
                "Town Market",
                "This is your Local Marketplace",
                "There is a vague smell of meat, herbs and fresh produce.",
                null,
                b1,
                null,
                a2,
                "A Seller in the Market says: \"I used to go fishing at the beach, but now theres monsters nearby!\"",
                () => { 
                    Console.WriteLine($"my name is {MainGame.player.name}");
                });
            a2.Populate(
                "Town Entrance",
                "This is an entrance to your Town.",
                "The angel on the top symbolizes that your village is peaceful.",
                null,
                b2,
                a1,
                a3,
                "A old villager by the entrance says: \"Hello my dear child, where have you come from ?\"");
            a3.Populate(
                "Town Square",
                "This is your Town Square.",
                "There is a wishing well in the middle.",
                null,
                b3,
                a2,
                a4,
                "A villager by the Well in the middle says: \"You should throw a gold coin in the well for good luck\"");
            a4.Populate(
                "Town Hall",
                "This is where the mayor lives",
                "Mum said \"This Building has a prison for baddies!\"",
                null,
                b4,
                a3,
                null,
                "The Mayor comes out of the town hall. He says: \"Beware all, for there are monsters south of here!\"");
            b1.Populate(
                "Chest",
                "This is an unlocked chest!",
                "The key is already in the Chest lock.",
                a1,
                c1,
                null,
                b2);
            b2.Populate(
                "Home",
                "This is your home!",
                "Your home is the same - nothing has changed",
                a2,
                c2,
                b1,
                b3,
                "\"Good luck on your journey.\", said your Mom.");
            b3.Populate(
                "Forest",
                "This is an oak forest.",
                "This forest has a crossway so you can go any way you want",
                a3,
                c3,
                b2,
                b4,
                "\"I will give you a reward if you save to town from the monsters\", said an old man");
            b4.Populate(
                "???",
                "This is an old Building.",
                "There is a button and a glowing circle on the floor.",
                a4,
                c4,
                b3,
                null);
            c1.Populate(
                "???",
                "This is an old Building.",
                "There is a button and a glowing circle on the floor.",
                b1,
                d1,
                null,
                c2);
            c2.Populate(
                "Forest",
                "This is an ash forest.",
                "This forest has a crossway so you can go any way you want.",
                b2,
                d2,
                c1,
                c3);
            c3.Populate(
                "Forest",
                "This is an birch forest.",
                "This forest has a crossway so you can go any way you want.",
                b3,
                d3,
                c2,
                c4);
            c4.Populate(
                "Dungeon",
                "This is a dangerous Dungeon.",
                "This Dungeon has dangers. Mum said to stay away from dangerous places.",
                b4,
                d4,
                c3,
                null);
            d1.Populate(
                "Beach",
                "This is a rocky beach",
                "This beach has lots of seaweed.",
                c1,
                null,
                null,
                d2);
            d2.Populate(
                "Beach",
                "This is a white, sandy Beach, with lots of children playing in the sand.", "This beach has lots of children playing on it.",
                c2,
                null,
                d1,
                d3,
                "\"my moomy sed dat da plase right of us is wery danegrus\" said one of the children");
            d3.Populate(
                "Dungeon",
                "This is a dangerous Dungeon.",
                "This Dungeon has dangers. Mum said to stay away from dangerous places.",
                c3,
                null,
                d2,
                d4);
            d4.Populate(
                "End Portal",
                "This is where you go if you want to leave this world.",
                "This is a way to go to a whole new world.",
                c4,
                null,
                d3,
                null);
        }
        // Creation of Actions
    }
}