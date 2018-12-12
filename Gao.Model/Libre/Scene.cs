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
        public SceneType Type { get; set; }
        public override string ToString()
        {
            return $"Type - {Type}";
        }
    }
}
