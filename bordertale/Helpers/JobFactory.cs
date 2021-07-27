using bordertale.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Helpers
{
    public static class JobFactory
    {
        public static Job CreateJob(string jobName)
        {
            switch (jobName.Trim().ToLower())
            {
                case "fighter":
                    return new Job("Fighter", 120, 40, (Weapon)ItemFactory.CreateItem("sword"));
                case "wizard":
                    return new Job("Wizard", 300, 20, (Weapon)ItemFactory.CreateItem("Knife"));
                case "healer":
                // TODO: Change Default Weapons
                    return new Job("Healer", 200, 20, (Weapon)ItemFactory.CreateItem("Knife"), 40);
                default:
                    return null;
            }
        }
    }
}
