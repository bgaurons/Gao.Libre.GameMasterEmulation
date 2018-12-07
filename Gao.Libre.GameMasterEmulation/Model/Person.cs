using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    public class Person
    {
        public PersonType Type { get; internal set; }
        public Foe FoeDetails { get; set; }
        public Trait Personality { get; internal set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type - {Type} Personality - {Personality}");
            if (FoeDetails != null) sb.AppendLine($"\tFoe - {FoeDetails.ToString().Replace(Environment.NewLine, Environment.NewLine + '\t')}");
            
            return sb.ToString();
        }
    }
}
