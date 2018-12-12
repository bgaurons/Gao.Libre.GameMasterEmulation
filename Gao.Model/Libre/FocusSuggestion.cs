using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    public class FocusSuggestion
    {
        public LocationAndQualityType? WildernessLocation { get; set; }
        public LocationAndQualityType? CivilizedLocation { get; set; }
        public Person Person { get; set; }
        public ItemType? Item { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (WildernessLocation != null) sb.Append($" Wilderness - {WildernessLocation}");
            if (CivilizedLocation != null) sb.Append($" Civilization - {CivilizedLocation}");
            if(Item!= null) sb.Append($" Item {Item}");
            sb.AppendLine();

            if(Person!= null)sb.AppendLine($"\tPerson - {Person.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t')}");

            return sb.ToString().Trim();
        }
    }
}
