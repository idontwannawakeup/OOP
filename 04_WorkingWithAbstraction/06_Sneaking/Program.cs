using System;
using System.Collections.Generic;

namespace _06_Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Game game = new Game();
            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                game.AddRow(row);
            }

            char[] samMoves = Console.ReadLine().ToCharArray();
            foreach (var move in samMoves)
            {
                game.MakeSamMove(move);
                if (game.IsCharacterDead(game.Sam) || game.IsCharacterDead(game.Nikoladze))
                    break;
            }
                   
            if (game.IsCharacterDead(game.Sam))
                Console.WriteLine($"Sam died at {game.Sam.i}, {game.Sam.j}");
            else if (game.IsCharacterDead(game.Nikoladze))
                Console.WriteLine("Nikoladze killed!");

            game.PrintRoom();

            Console.ReadKey();
        }
    }
}
