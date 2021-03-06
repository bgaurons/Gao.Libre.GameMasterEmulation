﻿using Gao.Model.Libre;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    /// <summary>
    /// The logic to generate a scene.
    /// </summary>
    public static class SceneFactory
    {
        /// <summary>
        /// Populates an opening scene, generating values randomly.
        /// </summary>
        /// <returns>Opening scene.</returns>
        public static Scene GenerateOpeningScene()
        {
            var returnValue = new Scene { Type = SceneType.Cutscene };

            return returnValue;
        }
    }
}
