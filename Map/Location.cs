namespace bordertale.Map
{
    public class Location
    {
        public Location(string zoneName, string description, string examination,
            Location up, Location down, Location left, Location right,
            string dialogue = "Theres nobody to talk to here...",
            bool solved = false)
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
    }
}
