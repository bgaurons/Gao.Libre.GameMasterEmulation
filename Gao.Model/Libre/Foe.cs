using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Foe details for a person that is also a foe.
    /// </summary>
    public class Foe
    {
        public CultureType? Culture { get; set; }
        public OccupationType? Occupation { get; set; }
        public int Quantity { get; set; }
        public int PointValue { get; set; }
        public bool IsCaptive { get; set; }
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
