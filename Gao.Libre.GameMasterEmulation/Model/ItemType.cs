using System;
using System.Collections.Generic;
using System.Text;

namespace Gao.Libre.GameMasterEmulation.Model
{
    /// <summary>
    /// Entries to the items table, p.134
    /// </summary>
    public enum ItemType
    {
        NobleDressAccessories = 1,
        IndeterminateClothing,
        IndeterminateAccessory,
        MilitaryUniform,
        ReligiousVestment,
        JewelryAdornment,
        GemsAndJewels,
        SemipreciousJewelry,
        ConcealableWeapons,
        SmallMeleeWeapons,
        LargeMeleeWeapons,
        SmallRangedWeapons,
        LargeRangedWeapons,
        ThrownWeapons,
        ReactiveExplosives,
        OddExoticWeapons,
        /// <summary>
        /// Also shows up at 26.
        /// </summary>
        [RepeatElement(26)]
        ArmoryCollection,
        LightPiecemealArmor,
        LeathersRiotGear,
        MediumProtection,
        HeavyProtection,
        ShieldRiotGear,
        Helmet,
        ExoticArmorProtection,
        HeavyPoweredArmor,
        ClothesFabrics = 27,
        Lighting,
        EatingGear,
        DrinkingGear,
        CookingGear,
        CraftToolsMachines,
        PortableShelterTents,
        HygieneBeautyItems,
        PotpourriIncense,
        TextDataReligious,
        SmallCeremonialItems,
        LargeCeremonyItems,
        DoorPortalContainer,
        ImagesIcons,
        /// <summary>
        /// Also shows up at 82
        /// </summary>
        [RepeatElement(82)]
        StatueSculpture,
        TextDataScienceMagic,
        HerbOrganicMedicine,
        ProcessedMedicine,
        PoisonPesticide,
        HardDrugs,
        InertCrystalRareEarth,
        PreservedOrganics,
        FlammablesExplosives,
        OccupationalGear,
        ArtScientificInstruments,
        InformationLocationOfItem,
        InformationReligiousMythic,
        InformationDimensionsExistence,
        InformationGeographic,
        InformationHistoryLore,
        InformationEcology,
        InformationMedicineAnatomy,
        InformationAccountingLedger,
        InformationDiaryPersonal,
        FreshFood,
        PreservedFood,
        RawFoodStuffs,
        FruitsVegetables,
        HerbsSpices,
        CheeseOrMeats,
        DrinkableInfusions,
        Alcohol,
        MildDrugTobaccoCoffee,
        IndustrialMetals,
        LumberOrganics,
        ConstructionMaterial,
        Ceramics,
        Cloth,
        PaperDataStorage,
        OilGreaseOrFuel,
        ValuableStone,
        SemipreciousStone,
        AnimalParts,
        IllustratedIlluminatedArt,
        PoetryProseMultimedia,
        Carving = 83,
        DrawingPainting,
        BigItemsMachinery,
        ReligiousPlaceInformation,
        PoliticalPlaceInformation,
        FortificationInformation,
        DefenseWeaknessInformation,
        MedicalDevicesMachines,
        ShopDevicesMachines,
        Furniture,
        SymbolicAncestralItems,
        SymbolicRulershipItems,
        /// <summary>
        /// 95-97
        /// </summary>
        [RepeatElement(96,97)]
        CashValuables,
        VehicleSmall = 98,
        VehicleMedium,
        VehicleLarge
    }
}
