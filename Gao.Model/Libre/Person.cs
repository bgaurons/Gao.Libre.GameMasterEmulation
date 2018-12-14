using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Comment Comment { get; set; }
        public PersonType Type { get; set; }
        public Foe FoeDetails { get; set; }
        public Trait Personality { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type - {Type} Personality - {Personality}");
            if (FoeDetails != null) sb.AppendLine($"\tFoe - {FoeDetails.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t')}");
            
            return sb.ToString();
        }
    }
}
