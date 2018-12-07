using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Common
{
    /// <summary>
    /// Methods that apply to enums.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets an attribute from an enum value.
        /// </summary>
        /// <typeparam name="TAttribute">The attribute to get</typeparam>
        /// <param name="value">An enum value that might or might not have the attribute</param>
        /// <returns>the attribute or null if the enum doesn't have the attribute.</returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name).GetCustomAttribute<TAttribute>();
        }
    }
}
