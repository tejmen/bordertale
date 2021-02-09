using System;

namespace bordertale
{
    class Program : MainGame
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MainGame.TitleScreen();
            Console.ReadKey();
        }
    }
}
