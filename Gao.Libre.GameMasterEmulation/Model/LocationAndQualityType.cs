using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// Civilized Qualities p.132
    /// </summary>
    /// <remarks>
    /// This table includes the civilized location tables (1-100)
    /// and the wilderness qualities (101-200).
    /// Civilized places are entries 1-20.
    /// Rationales are the last 81-100.
    /// Wilderness Locations are 101-120
    /// </remarks>
    public enum LocationAndQualityType
    {
        SquareMeetingHall = 1,
        WarehouseStorage,
        Marketplace,
        FarmVillaEstate,
        SmithyFactory,
        CraftingPlace,
        ShopStore,
        TavernInnHotel,
        ArenaSportsPlace,
        StreetsAlleys,
        LuxuryDigs,
        LibraryOrLab,
        PalaceFortressHeadquarters,
        KeepTower,
        FieldMeadow,
        GardenLawnPark,
        TempleChurch,
        HomeHovel,
        CellarUnderground,
        PortStationTransit,
        Memorial,
        Crowded,
        Plants,
        GarbageRubble,
        OffalSmell,
        CookingSmells,
        PollutionSmog,
        ChemicalSmells,
        IncensePerfumed,
        StuffyStaleSmell,
        Cramped,
        FurnitureStrewn,
        Curtained,
        MachineryMagic,
        BackgroundNoise,
        Music,
        StairsRamps,
        Terraced,
        Vehicles,
        FenceHedge,
        Ditch,
        DankDamp,
        /// <summary>
        /// also 143
        /// </summary>
        [RepeatElement(143)]
        BrightWellLit = 43,
        /// <summary>
        /// also 144
        /// </summary>
        [RepeatElement(144)]
        GloomyDimlyLit,
        /// <summary>
        /// also 145
        /// </summary>
        [RepeatElement(145)]
        TwilightDusk,
        /// <summary>
        /// also 146
        /// </summary>
        [RepeatElement(146)]
        Shadowy,
        /// <summary>
        /// also 149
        /// </summary>
        [RepeatElement(149)]
        Hazy,
        /// <summary>
        /// also 150
        /// </summary>
        [RepeatElement(150)]
        Foggy,
        /// <summary>
        /// also 151
        /// </summary>
        [RepeatElement(151)]
        Dusty,
        /// <summary>
        /// also 152
        /// </summary>
        [RepeatElement(152)]
        Smoky,
        /// <summary>
        /// also 153
        /// </summary>
        [RepeatElement(153)]
        WideOpenSpaces,
        HighObservationPoint,
        /// <summary>
        /// also 155
        /// </summary>
        [RepeatElement(155)]
        SightBlocking,
        /// <summary>
        /// also 156
        /// </summary>
        [RepeatElement(156)]
        Hot,
        /// <summary>
        /// also 157
        /// </summary>
        [RepeatElement(157)]
        Humid,
        /// <summary>
        /// also 158
        /// </summary>
        [RepeatElement(158)]
        Cold,
        /// <summary>
        /// also 159
        /// </summary>
        [RepeatElement(159)]
        Dry,
        /// <summary>
        /// also 160
        /// </summary>
        [RepeatElement(160)]
        Breezy,
        /// <summary>
        /// also 161
        /// </summary>
        [RepeatElement(161)]
        Windy,
        /// <summary>
        /// also 162
        /// </summary>
        [RepeatElement(162)]
        Gale,
        /// <summary>
        /// also 163
        /// </summary>
        [RepeatElement(163)]
        Cloudy,
        /// <summary>
        /// also 164
        /// </summary>
        [RepeatElement(164)]
        Overcast,
        /// <summary>
        /// also 165
        /// </summary>
        [RepeatElement(165)]
        Stormy,
        /// <summary>
        /// also 166
        /// </summary>
        [RepeatElement(166)]
        Clear,
        /// <summary>
        /// also 167
        /// </summary>
        [RepeatElement(167)]
        Still,
        /// <summary>
        /// also 168
        /// </summary>
        [RepeatElement(168)]
        Sprinkling,
        /// <summary>
        /// also 169
        /// </summary>
        [RepeatElement(169)]
        RainSleetSnow,
        /// <summary>
        /// also 170
        /// </summary>
        [RepeatElement(170)]
        DownpourBlizzard,
        WorkSounds,
        /// <summary>
        /// also 172
        /// </summary>
        [RepeatElement(172)]
        RunningWater,
        /// <summary>
        /// also 173
        /// </summary>
        [RepeatElement(173)]
        BlowingWinds,
        TrafficPassersBy,
        Birdsong,
        AnimalSounds,
        /// <summary>
        /// also 178
        /// </summary>
        [RepeatElement(178)]
        QuietSerene,
        /// <summary>
        /// also 179
        /// </summary>
        [RepeatElement(179)]
        FloralSweetSmells,
        /// <summary>
        /// also 182
        /// </summary>
        [RepeatElement(182)]
        SolidHardGround,
        /// <summary>
        /// also 183
        /// </summary>
        [RepeatElement(183)]
        SoftPlushGround,
        /// <summary>
        /// also 184
        /// </summary>
        [RepeatElement(184)]
        SmoothSlipGround,
        /// <summary>
        /// also 185
        /// </summary>
        [RepeatElement(185)]
        RoughGround,
        Conversation,
        ArgueDebate,
        StudyLearn,
        /// <summary>
        /// 84-85
        /// </summary>
        [RepeatElement(85)]
        GuardVigilance,
        /// <summary>
        /// 86-87
        /// </summary>
        [RepeatElement(87)]
        AnxietyFear = 86,
        /// <summary>
        /// 88-89
        /// </summary>
        [RepeatElement(89)]
        HateAnger = 88,
        HuntScavenge = 90,
        WelcomeFriendly,
        WorshipReverent,
        SickDiseased,
        DrunkDrugged,
        HurtSuffering,
        RespectGrateful,
        CelebrateFest,
        TiredRestSleep,
        CookEatDrink,
        LackHungryPoor,
        Underground = 101,
        CaveCaverns,
        MineShaftTunnel,
        FissureCrevasse,
        RuinsBuildings,
        TaigaTundraDesert,
        ForestDeciduous,
        ForestConiferous,
        SwampMarsh,
        JungleVines,
        ScrubBrush,
        SteppesGrasslands,
        BrokenBlastedArea,
        CliffsCragsGorges,
        Hills,
        Mountains,
        Plateau,
        Valley,
        CanyonChasm,
        PondLakeShore,
        Landmark,
        RiverShore,
        Stream,
        OceanShore,
        VineChoked,
        Overgrown,
        Vines,
        Underbrush,
        Cobwebs,
        ToxicPoisonFumes,
        DiseaseRidden,
        WildlifeSigns,
        MonstrousSigns,
        InsectSwarms,
        VerminPests,
        SandyLoose,
        GravelShale,
        Muddy,
        IcyOrWetSlick,
        SmoothStone,
        LooseStoneBoulders,
        Rooty,
        DarkAsNight = 147,
        PitchDark,
        ObservationPoint = 154,
        Dew = 171,
        RainfallPatter = 174,
        BirdCalls,
        SmallAnimalSounds,
        LargeAnimalSounds,
        MildewMoldSmell = 180,
        RottenCarrionSmell,
        Deserted = 186,
        Abandoned,
        Desolate,
        Empty,
        Eerie,
        Forbidding,
        Protected,
        Exposed,
        UnstableHazardous,
        FireSet,
        MysticBlessCurse,
        ArtifactObject,
        GuardiansGuarded,
        Illusory,
        TrappedWarded
    }
}
