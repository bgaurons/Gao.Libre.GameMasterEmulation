using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// A type of occupation for a character
    /// </summary>
    public enum OccupationType
    {
        [RepeatElement(2)]
        Common = 1,
        SocialLeadership = 3,
        FightersWarriors,
        TravelersRogues,
        WildernessSpecialist,
        OfficersSpecialForces,
        AcademicSpecialist,
        ReligiousInspirational,
        SettingsSkillsSpecialist
    }
}
