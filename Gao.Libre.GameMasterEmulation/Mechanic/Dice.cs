using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    public static class Dice
    {
        /// <summary>
        /// The commonly used random number function.
        /// </summary>
        private static Random NumberGenerator { get; } = new Random();

        private static int Next(int minValue, int maxValue)
        {
            return NumberGenerator.Next(minValue, maxValue);
        }

        private static Func<int, int, int> _nextFunction = null;
        /// <summary>
        /// A function to get a number from min inclusive to max exclusive.
        /// </summary>
        /// <remarks>Done for DI</remarks>
        public static Func<int, int, int> NextFunction
        {
            get
            {
                return _nextFunction ?? (_nextFunction = Next);
            }
            set
            {
                _nextFunction = value;
            }
        }

        /// <summary>
        /// Rolls the standard number of dice with the given number of sides.
        /// </summary>
        /// <param name="quantity">number to throw</param>
        /// <param name="sides">number of sides on the dice</param>
        /// <returns>the result of each die roll</returns>
        public static int[] Roll(int quantity, int sides)
        {
            return Roll(quantity, Enumerable.Range(1, sides - 1).ToArray());
        }
        
        /// <summary>
        /// Returns the results of the provided die
        /// </summary>
        /// <param name="quantity">Number of dice to roll</param>
        /// <param name="sides">All possible die faces.</param>
        /// <returns>The roll results.</returns>
        public static int[] Roll(int quantity, int[] sides)
        {
            return
                Enumerable.Range(0, quantity).
                Select(d => sides[NextFunction(0, sides.Length)]).
                ToArray();
        }

    }
}
