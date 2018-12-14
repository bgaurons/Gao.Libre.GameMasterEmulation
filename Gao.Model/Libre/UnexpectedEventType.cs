using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Model.Libre
{
    public enum UnexpectedEventType
    {
        Arrival = 1,
        Departure,
        TraitPositive,
        TraitNegative,
        TraitRandom,
        SkillCheck,
        RationaleNewChange,
        MissionNewChange,
        SceneQualityIntrudes,
        ItemIntrudes,
        StartCeaseHostilities,
        LeaderEmerges,
        SpecialItem,
        CallForBackup,
        AddsReinforcements,
        TrapAmbushArrestConfine,
        TrapAmbushDamageIncapacitate,
        MonsterBeast,
        SceneQualityNewChange,
        SceneQualityCeases
    }
}
