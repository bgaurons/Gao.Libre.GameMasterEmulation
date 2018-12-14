using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// A unit of game time.
    /// </summary>
    public class Scene
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Comment Comment { get; set; }
        public SceneType Type { get; set; }
        public int PlotStress { get; set; }
        public int AskingForTrouble { get; set; }
        public bool Complete { get; set; }
        public bool MeaningfulSuccess { get; set; }
        public override string ToString()
        {
            return $"Type - {Type}";
        }
    }
}
