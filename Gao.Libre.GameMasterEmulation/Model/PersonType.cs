using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// Types of person one might meet, p.131
    /// </summary>
    /// <remarks>
    /// Foes are the last twenty items.
    /// </remarks>
    public enum PersonType
    {
        LocalLeaderStaff = 1,
        RegionalLeaderStaff,
        NationalLeaderStaff,
        ServantOfRoyalty,
        LocalLeaderInnerCircle,
        RegionalLeaderInnerCircle,
        NationalLeaderInnerCircle,
        RoyalFamily,
        LocalLeader,
        RegionalLeader,
        SpyAgent,
        ReligiousLayFolk,
        ReligiousMeditativeScholar,
        ReligiousActivistCultist,
        ReligionStaff,
        ReligionInnerCircle,
        MercenaryArmsGuild,
        MercenaryArmsLeaderBoss,
        MerchantsBusinessFinance,
        MerchantFinanceBoss,
        RogueGuildSmugglers,
        RogueSmuggleLeader,
        ScholarScientist,
        AcademicLuminary,
        CraftersManufacturing,
        CrafterManufacturingLeader,
        ConscriptMilitia,
        ArmyMarineSoldier,
        ArcherAirSeasoldier,
        NonCommissionedOfficerSpecialist,
        OfficerMilitaryLeader,
        PolicePublicSafety,
        Cousin,
        InlawIndirectFamily,
        NieceNephew,
        AuntUncle,
        ParentsGrandparents,
        BrotherSister,
        ChildDependent,
        FamilyFriend,
        ChildhoodFriend,
        NeighborAcquaintance,
        EarlyFirstLove,
        TeacherOrColleague,
        BeggarPoor,
        RoleModel,
        FormerFriend,
        FormerLove,
        OccupationalPeer,
        BadBloodFamily,
        HostileForeigner,
        RivalOfFriendAlly,
        IdeologicalRival,
        GeneralTroublemaker,
        DespicableVillain,
        SkilledHero,
        AgedHero,
        LiarBraggart,
        CraftmasterBoss,
        ExceptionalTalent,
        ExceptionalBeauty,
        WealthyEntrepreneur,
        PrestigiousFamily,
        ExpertHistorianLore,
        SpecialtyAcademician,
        ExpertHealerDoctor,
        DiplomaticExpert,
        PopularEntertainer,
        MasterBuilderEngineer,
        NomadTraveler,
        LiarHoaxer,
        ScoutMessenger,
        TerroristAnarchist,
        UnremarkableCommoner,
        /// <summary>
        /// 75-78
        /// </summary>
        [RepeatElement(76,77,78)]
        PotentialPatronAlly,
        /// <summary>
        /// 79-80
        /// </summary>
        [RepeatElement(80)]
        PotentialRivalPastFoe = 79,
        WeakTeam = 81,
        AverageTeam,
        AverageNonPlayerCharacter,
        TalentedNonPlayerCharacter,
        AddLeader,
        AnimalsMounts,
        NonCombatant,
        WeakMinions,
        AverageMinions,
        BigBrute,
        VehiclesMounts,
        WeakMindlessMinion,
        AverageMindlessMinion,
        HybridsAnimals,
        PowerfulEntity,
        Automaton,
        SpecialAverageNonPlayerCharacter,
        SpecialTalentedNonPlayerCharacter,
        Captives,
        InfiltratorSpy
    }
}
