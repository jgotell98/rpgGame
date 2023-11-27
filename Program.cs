using System;

namespace StarterGame
{
    class Program
    {
       static Game game;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            game = new Game();
            game.start();
            game.play();
            game.end();
        }
    }
}
