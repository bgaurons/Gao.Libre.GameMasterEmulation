using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    /// <summary>
    /// Types of missions
    /// </summary>
    /// <remarks>Can find descriptions on p. 123</remarks>
    public enum MissionType
    {
        /// <summary>
        /// Travel to the edge of a familiar/controlled area. Maintain safety and order in the area by removing potential threats.
        /// </summary>
        Patrol = 1,
        Scout,
        FindRecover,
        Explore,
        Hunt,
        Capture,
        Spy,
        Escort,
        Deliver,
        Investigate,
        Negotiate,
        WinOver,
        Survive,
        Evade,
        Escape,
        Defend,
        Protect,
        Attack,
        Rescue,
        Research
    }
}
