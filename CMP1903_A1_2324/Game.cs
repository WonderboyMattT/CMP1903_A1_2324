using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    public class Game
    {
        private List<Die> _diceRolls = new List<Die>();
        private int _sum;
        
        public Game()
        {

            for (int i = 0; i < 3; i++)
            {
                _diceRolls.Add(new Die());
            }
        }

        // Rolls the dice
        public int RollDice()
        {

            foreach (Die die in _diceRolls)
            {
                int rollValue = die.Roll();
                Console.WriteLine(rollValue);
                _sum += rollValue;
            }
            return _sum;
        }

        // Return all dice
        public Array ReturnDice() { return _diceRolls.ToArray(); }
    }
}