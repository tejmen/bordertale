using System;

namespace bordertale
{
    class Program : MainGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _______  _______  ______    ______   _______  ______    _______  _______  ___      _______ ");
            Console.WriteLine("|  _    ||       ||    _ |  |      | |       ||    _ |  |       ||   _   ||   |    |       |");
            Console.WriteLine("| |_|   ||   _   ||   | ||  |  _    ||    ___||   | ||  |_     _||  |_|  ||   |    |    ___|");
            Console.WriteLine("|       ||  | |  ||   |_||_ | | |   ||   |___ |   |_||_   |   |  |       ||   |    |   |___ ");
            Console.WriteLine("|  _   | |  |_|  ||    __  || |_|   ||    ___||    __  |  |   |  |       ||   |___ |    ___|");
            Console.WriteLine("| |_|   ||       ||   |  | ||       ||   |___ |   |  | |  |   |  |   _   ||       ||   |___ ");
            Console.WriteLine("|_______||_______||___|  |_||______| |_______||___|  |_|  |___|  |__| |__||_______||_______|\n");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Screens.TitleScreen();
            Console.ReadKey();
        }
    }
}
