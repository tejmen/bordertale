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
                    return new Job("Fighter", 120, 40);
                case "wizard":
                    return new Job("Wizard", 300, 20);
                case "healer":
                    return new Job("Healer", 200, 20, 40);
                default:
                    return null;
            }
        }
    }
}
