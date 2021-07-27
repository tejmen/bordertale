using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bordertale.Helpers
{
    class AutoCompletionHandler : IAutoCompleteHandler
    {
        // characters to start completion from
        public char[] Separators { get; set; } = new char[] { ' ' };

        // text - The current text entered in the console
        // index - The index of the terminal cursor within {text}
        public string[] GetSuggestions(string text, int index)
        {
            if (text.StartsWith("move "))
                return new string[] { "up", "down", "left", "right", "north", "south", "east", "west" };
            else
                return new string[] { "move", "quit", "help", "stats", "act", "mission" };
        }
    }
}
