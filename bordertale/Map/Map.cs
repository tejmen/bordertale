using bordertale.Helpers;
using System;
using System.Threading;

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
        public static Location GetLocation(string locationName)
        {
            var type = typeof(Map);
            var locationField = type.GetField(locationName);
            Location location = (Location)locationField.GetValue(null);
            return location;
        }
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
                () =>
                {
                    if (MainGame.player.money == 0)
                    {
                        PrintUtils.SlowPrint("\"Go get money so you can buy stuff!\" shouts one of the merchants.", 100);
                    }
                    else
                    {
                        // @todo Add Screen.Shop()
                    }
                });
            a2.Populate(
                "Town Entrance",
                "This is an entrance to your Town.",
                "The angel on the top symbolizes that your village is peaceful.",
                null,
                b2,
                a1,
                a3,
                "A old villager by the entrance says: \"Hello my dear child, where have you come from ?\"",
                () =>
                {
                    Console.WriteLine("The mayoral election are going on. Everyone is talking about it.");
                });
            a3.Populate(
                "Town Square",
                "This is your Town Square.",
                "There is a wishing well in the middle.",
                null,
                b3,
                a2,
                a4,
                "A villager by the Well in the middle says: \"You should throw a gold coin in the well for good luck\"",
                () =>
                {
                    Console.WriteLine("I wish I could get good luck, but I dont have any money.");
                });
            a4.Populate(
                "Town Hall",
                "This is where the mayor lives",
                "Mum said \"This Building has a prison for baddies!\"",
                null,
                b4,
                a3,
                null,
                "The Mayor comes out of the town hall. He says: \"Beware all, for there are monsters south of here!\"",
                () =>
                {
                    Console.WriteLine("There is a weird smell of rotten eggs inside. I'm not going inside!");
                });
            b1.Populate(
                "Chest",
                "This is an unlocked chest!",
                "The key is already in the Chest lock.",
                a1,
                c1,
                null,
                b2,
                action: () =>
                {
                    Console.WriteLine("You pick up the knife.");
                    MainGame.player.Acquire(Helpers.ItemFactory.CreateItem("knife"));
                });
            b2.Populate(
                "Home",
                "This is your home!",
                "Your home is the same - nothing has changed",
                a2,
                c2,
                b1,
                b3,
                "\"Good luck on your journey.\", said your Mom.",
                () =>
                {
                    PrintUtils.SlowPrint("You take a nap.", 100);
                    MainGame.player.HpReset();
                });
            b3.Populate(
                "Forest",
                "This is an oak forest.",
                "This forest has a crossway so you can go any way you want",
                a3,
                c3,
                b2,
                b4,
                "\"I will give you a reward if you save the town from the monsters\", said an old man",
                () =>
                {
                    if (MainGame.player.xp == 0)
                    {
                        PrintUtils.SlowPrint("\"I will give you some money if you defeat the monsters south of here\" said an old man.", 100);
                        // @todo add 'Defeat Monsters' Mission
                    }
                    else
                    {
                        PrintUtils.SlowPrint("I have given you some money.", 100);
                        PrintUtils.SlowPrint("Now go away!", 75);
                        // @todo Move Mission Completed Actions when Missions are created
                        MainGame.player.Pay(40);
                        MainGame.player.location.solved = true;
                    }
                });
            b4.Populate(
                "???",
                "This is an old Building.",
                "There is a button and a glowing circle on the floor.",
                a4,
                c4,
                b3,
                null,
                action: () =>
                {
                    MainGame.player.location.zoneName = "Teleporter";
                    MainGame.player.SetLocation(c1);
                    MainGame.player.location.zoneName = "Teleporter";
                });
            c1.Populate(
                "???",
                "This is an old Building.",
                "There is a button and a glowing circle on the floor.",
                b1,
                d1,
                null,
                c2,
                action: () =>
                {
                    //Might make random?
                    MainGame.player.location.zoneName = "Teleporter";
                    MainGame.player.SetLocation(b4);
                    MainGame.player.location.zoneName = "Teleporter";
                });
            c2.Populate(
                "Forest",
                "This is an ash forest.",
                "This forest has a crossway so you can go any way you want.",
                b2,
                d2,
                c1,
                c3,
                action: () =>
                {
                    if (Map.c1.zoneName == "Teleporter")
                    {
                        // Move this too
                        Console.WriteLine("\"Thank you for finding out what that place was! I'll give you a reward for doing that\", said a mysterious man, giving you some money.");
                        MainGame.player.Pay(30);
                        MainGame.player.location.solved = true;
                    }
                    else
                    {
                        Console.WriteLine("\"Can you please find out what is in the place to the left of us. I really want to go there, but I'm too scared!\", said a mysterious man.");
                        // Add mission here
                    }
                });
            c3.Populate(
                "Forest",
                "This is an birch forest.",
                "This forest has a crossway so you can go any way you want.",
                b3,
                d3,
                c2,
                c4,
                action: () =>
                {
                    PrintUtils.SlowPrint("You take a nap", 100);
                    MainGame.player.HpReset();
                    Thread.Sleep(1000);
                });
            c4.Populate(
                "Dungeon",
                "This is a dangerous Dungeon.",
                "This Dungeon has dangers. Mum said to stay away from dangerous places.",
                b4,
                d4,
                c3,
                null,
                action: () =>
                {
                    CombatHandler.Combat(MobFactory.CreateMob("random"));
                });
            d1.Populate(
                "Beach",
                "This is a rocky beach",
                "This beach has lots of seaweed.",
                c1,
                null,
                null,
                d2,
                action: () =>
                {
                    Console.WriteLine("The beach is too rocky to do anything.");
                });
            d2.Populate(
                "Beach",
                "This is a white, sandy Beach, with lots of children playing in the sand.", "This beach has lots of children playing on it.",
                c2,
                null,
                d1,
                d3,
                "\"my moomy sed dat da plase right of us is wery danegrus\" said one of the children",
                () =>
                {
                    PrintUtils.SlowPrint("This beach is so sandy that...", 100);
                    PrintUtils.SlowPrint("you take a nap. ", 100);
                    MainGame.player.HpReset();
                });
            d3.Populate(
                "Dungeon",
                "This is a dangerous Dungeon.",
                "This Dungeon has dangers. Mum said to stay away from dangerous places.",
                c3,
                null,
                d2,
                d4,
                action: () =>
                {
                    CombatHandler.Combat(MobFactory.CreateMob("random"));
                });
            d4.Populate(
                "End Portal",
                "This is where you go if you want to leave this world.",
                "This is a way to go to a whole new world.",
                c4,
                null,
                d3,
                null,
                action: () =>
                {
                    // @todo Add Second Map
                    PrintUtils.SlowPrint("Thanks for Playing!");
                    MainGame.EndGame();
                });
        }
    }
}
