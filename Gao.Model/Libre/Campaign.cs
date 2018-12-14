using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Tracks variables that change as things progress
    /// </summary>
    public class Campaign
    {
        public long OwnerId { get; set; }
        public long Id { get; set; }

        public string Name { get; set; }
        public Comment Comment { get; set; }

        public ICollection<Mission> Missions { get; set; } = new List<Mission>();

        public ICollection<Person> Characters { get; set; } = new List<Person>();

    }
}
