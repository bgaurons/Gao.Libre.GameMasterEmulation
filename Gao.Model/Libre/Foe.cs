using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Foe details for a person that is also a foe.
    /// </summary>
    public class Foe
    {
        public long Id { get; set; }
        public Comment Comment { get; set; }
        public CultureType? Culture { get; set; }
        public OccupationType? Occupation { get; set; }
        /// <summary>
        /// If not null, there is a minimum recommendation
        /// </summary>
        [NotMapped]
        public int? MinimumQuantity { get; set; }
        /// <summary>
        /// If not null, there is a maximum recommendation
        /// </summary>
        [NotMapped]
        public int? MaximumQuantity { get; set; }
        /// <summary>
        /// Tells if there are more than one encounter.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// If not null, there is a minimum recommendation
        /// </summary>
        [NotMapped]
        public int? MinimumPointValue { get; set; }
        /// <summary>
        /// If not null, there is a maximum recommendation
        /// </summary>
        [NotMapped]
        public int? MaximumPointValue { get; set; }
        /// <summary>
        /// A number of points that represent effective toughness of this encounter
        /// </summary>
        public int[] PointValue { get; set; } = new int[0];
        public bool IsCaptive { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Quantity - {Quantity} Point Value - {PointValue.Select(pv=> pv.ToString()).Aggregate((accum, next) => accum +", " + next)} Captive? {IsCaptive}");
            if (Occupation != null)
                sb.AppendLine($"\tOccupation - {Occupation} Culture - {Culture}");
            return sb.ToString();
        }
    }
}
