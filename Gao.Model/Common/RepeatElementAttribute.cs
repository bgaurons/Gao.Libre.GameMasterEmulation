using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Common
{ 
    /// <summary>
    /// For random tables based on enumeration values, it says to not return any values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ExcludeElementAttribute : Attribute
    {


    }
}
