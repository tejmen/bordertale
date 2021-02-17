namespace bordertale.Map
{
    public static class Map
    {
        public static Location a1 = new Location(
            "Town Market",
            "This is your Local Marketplace",
            "There is a vague smell of meat, herbs and fresh produce.",
            null,
            b1,
            null,
            a2,
            "A Seller in the Market says: \"I used to go fishing at the beach, but now theres monsters nearby!\"");
        public static Location a2 = new Location(
            "Town Entrance",
            "his is an entrance to your Town.",
            "The angel on the top symbolizes that your village is peaceful.",
            null,
            b2,
            a1,
            a3,
            "A old villager by the entrance says: \"Hello my dear child, where have you come from ?\"");
        public static Location a3 = new Location(
            "Town Square",
            "This is your Town Square.",
            "There is a wishing well in the middle.",
            null,
            b3,
            a2,
            a4,
            "A villager by the Well in the middle says: \"You should throw a gold coin in the well for good luck\"");
        public static Location a4 = new Location(
            "Town Hall",
            "This is where the mayor lives",
            "Mum said \"This Building has a prison for baddies!\"",
            null,
            b4,
            a3,
            null,
            "The Mayor comes out of the town hall. He says: \"Beware all, for there are monsters south of here!\"");
        public static Location b1 = new Location(
            "Chest",
            "This is an unlocked chest!",
            "The key is already in the Chest lock.",
            a1,
            c1,
            null,
            b2);
        public static Location b2 = new Location(
            "Home",
            "This is your home!",
            "Your home is the same - nothing has changed",
            a2,
            c2,
            b1,
            b3,
            "\"Good luck on your journey.\", said your Mom.");
        public static Location b3 = new Location(
            "Forest",
            "This is an oak forest.",
            "This forest has a crossway so you can go any way you want",
            a3,
            c3,
            b2,
            b4,
            "\"I will give you a reward if you save to town from the monsters\", said an old man");
        public static Location b4 = new Location(
            "???",
            "This is an old Building.",
            "There is a button and a glowing circle on the floor.",
            a4,
            c4,
            b3,
            null);
        public static Location c1 = new Location(
            "???",
            "This is an old Building.",
            "There is a button and a glowing circle on the floor.",
            b1,
            d1,
            null,
            c2);
        public static Location c2 = new Location(
            "Forest",
            "This is an ash forest.",
            "This forest has a crossway so you can go any way you want.",
            b2,
            d2,
            c1,
            c3);
        public static Location c3 = new Location(
            "Forest",
            "This is an birch forest.",
            "This forest has a crossway so you can go any way you want.",
            b3,
            d3,
            c2,
            c4);
        public static Location c4 = new Location(
            "Dungeon",
            "This is a dangerous Dungeon.",
            "This Dungeon has dangers. Mum said to stay away from dangerous places.",
            b4,
            d4,
            c3,
            null);
        public static Location d1 = new Location(
            "Beach",
            "This is a rocky beach",
            "This beach has lots of seaweed.",
            c1,
            null,
            null,
            d2);
        public static Location d2 = new Location(
            "Beach",
            "This is a white, sandy Beach, with lots of children playing in the sand.", "This beach has lots of children playing on it.",
            c2,
            null,
            d1,
            d3,
            "\"my moomy sed dat da plase right of us is wery danegrus\" said one of the children");
        public static Location d3 = new Location(
            "Dungeon",
            "This is a dangerous Dungeon.",
            "This Dungeon has dangers. Mum said to stay away from dangerous places.",
            c3,
            null,
            d2,
            d4);
        public static Location d4 = new Location(
            "End Portal",
            "This is where you go if you want to leave this world.",
            "This is a way to go to a whole new world.",
            c4,
            null,
            d3,
            null);
    }
}
