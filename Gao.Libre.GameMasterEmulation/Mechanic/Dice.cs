using Gao.Libre.GameMasterEmulation.Common;
using System.Linq;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    public static class Dice
    {


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
                Select(d => sides[RandomNumberGeneration.NextFunction(0, sides.Length)]).
                ToArray();
        }

    }
}
