using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// A Type of Culture
    /// </summary>
    public enum CultureType
    {
        [RepeatElement(2,3)]
        MajorityNative = 1,
        NativeMinority = 4,
        /// <summary>
        /// 5-6
        /// </summary>
        [RepeatElement(6)]
        AffiliatedNeighbor,
        FarAwayForeign = 7,
        UnusualExotic,
        /// <summary>
        /// 9-10
        /// </summary>
        [RepeatElement(10)]
        Opposed

    }
}
