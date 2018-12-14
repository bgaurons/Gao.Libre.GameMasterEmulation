using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Represents a unit of play with a beginning middle and end. it is composed of many scenes.
    /// </summary>
    public class Mission
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Comment Comment { get; set; }
        public MissionType Type { get; set; }

        public FocusSuggestion Suggestions { get; set; }
        public LocationAndQualityType Purpose { get; set; }
        /// <summary>
        /// The number of good things someone needs to resolve to call the mission a success
        /// </summary>
        public int MeaningfulSuccessesToResolve { get; set; } = 2;

        public ICollection<Person> PatronsPersons { get; } = new List<Person>();

        public ICollection<Person> AlliesGroups { get; } = new List<Person>();

        public ICollection<Mission> SideMissions { get; } = new List<Mission>();

        public ICollection<Scene> Scenes { get; } = new List<Scene>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type - {Type} Purpose - {Purpose} Successes Needed: {MeaningfulSuccessesToResolve}");
            sb.AppendLine($"\tFocus Suggestions {Suggestions.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t')}");
            foreach(var person in PatronsPersons)
            {
                sb.AppendLine("\tPatron " + person.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t'));
            }
            foreach (var person in AlliesGroups)
            {
                sb.AppendLine("\tAlly " + person.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t'));
            }
            foreach (var scene in Scenes)
            {
                sb.AppendLine("\tScene " + scene.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t'));
            }
            return sb.ToString();
        }
    }
}
