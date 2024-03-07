using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Die

    {
        private int _currentValue;
        private static Random _random;

        // The Die constructor initialises the random number generator. Each new instance of the die class will be generated with its own independent "random".
        public Die()
        {
            _random = new Random();
        }

        // Method that rolls the die and return the result
        public int Roll()
        {
            // Generates a random number between 1 and 6. Next is a method of the Random class in .Net
            _currentValue = _random.Next(1, 7); // Numbers generated are stored in the _currentValue variable.
            return _currentValue;
        }

        // Gets the current value of the die
        public int CurrentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }
    }
}