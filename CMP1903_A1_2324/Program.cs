using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing.TestDieClass();
            //Testing.TestGameClass();
            // Create a Game object
            Game game = new Game();

            // Roll the dice and get the sum
            int total = game.RollDice();

            // Reports the total of the three dice rolls
            Console.WriteLine("Total of the three dice rolls: " + total);

            // Stop code from self terminating
            Console.ReadKey();
        }
    }
}