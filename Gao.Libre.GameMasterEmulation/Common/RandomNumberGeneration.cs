using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Common
{
    /// <summary>
    /// Factored out random number generation to make testing easier.
    /// </summary>
    public static class RandomNumberGeneration
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
    }
}
