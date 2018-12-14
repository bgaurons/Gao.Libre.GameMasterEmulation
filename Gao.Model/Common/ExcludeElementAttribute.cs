using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Common
{ 
    /// <summary>
    /// I based a lot of random lookup tables on enumerations, but sometimes
    /// values in a table show up in multiple indices, e.g. a roll of 1,2,3 might give the
    /// same enum. This helps alleviate that problem.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class RepeatElementAttribute : Attribute
    {
        /// <summary>
        /// What other values this enum corresponds to.
        /// </summary>
        public int[] OtherIndices { get; set; }
        /// <summary>
        /// Useless
        /// </summary>
        protected RepeatElementAttribute() : this(new int[0])
        {
            
        }
        /// <summary>
        /// Provides a list of redundant enum values.
        /// </summary>
        /// <param name="otherIndices">The other backing values to associate with this enum</param>
        public RepeatElementAttribute(params int[] otherIndices) 
        {
            OtherIndices = otherIndices;
        }

    }
}
