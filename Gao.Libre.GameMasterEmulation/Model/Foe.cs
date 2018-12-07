using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// Foe details for a person that is also a foe.
    /// </summary>
    public class Foe
    {
        public CultureType? Culture { get; internal set; }
        public OccupationType? Occupation { get; internal set; }
        public int Quantity { get; internal set; }
        public int PointValue { get; internal set; }
        public bool IsCaptive { get; internal set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Quantity - {Quantity} Point Value - {PointValue} Captive? {IsCaptive}");
            if (Occupation != null)
                sb.AppendLine($"\tOccupation - {Occupation} Culture - {Culture}");
            return sb.ToString();
        }
    }
}
