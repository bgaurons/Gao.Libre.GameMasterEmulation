using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// A unit of game time.
    /// </summary>
    public class Scene
    {
        public SceneType Type { get; internal set; }
        public override string ToString()
        {
            return $"Type - {Type}";
        }
    }
}
