﻿using Gao.Libre.GameMasterEmulation.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using rng = Gao.Libre.GameMasterEmulation.Common.RandomNumberGeneration;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    /// <summary>
    /// Logic for getting random tables and their results.
    /// </summary>
    public static class RandomTable
    {
        /// <summary>
        /// Converts an enum into a dictionary which can be used to choose a random value.
        /// </summary>
        /// <typeparam name="TEnum">An enumeration type</typeparam>
        /// <returns>A dictionary of all enum values</returns>
        /// <exception cref="ArgumentException">If TEnum is not an enum type.</exception>
        public static Dictionary<int,TEnum> EnumToDictionary<TEnum>() where TEnum : struct, IConvertible
        {
            var type = typeof(TEnum);
            if (!type.IsEnum) throw new ArgumentException(nameof(TEnum));
            return
                ((TEnum[])Enum.GetValues(type)).
                SelectMany(e => 
                {
                    var name = Enum.GetName(type, e);
                    var additionalEntries = type.GetField(name).GetCustomAttribute<RepeatElementAttribute>();
                    var returnValue = new List<KeyValuePair<int, TEnum>>
                    {
                        new KeyValuePair<int, TEnum>(e.ToInt32(CultureInfo.InvariantCulture), e)
                    };
                    if(additionalEntries != null)
                    {
                        returnValue.AddRange
                        (
                            additionalEntries.
                            OtherIndices.
                            Select(i => new KeyValuePair<int, TEnum>(i, e))
                        );
                    }
                    return returnValue;
                    
                }).
                ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        /// <summary>
        /// Chooses a random enum element from the given dictionary.
        /// </summary>
        /// <typeparam name="TEnum">Enumeration type</typeparam>
        /// <param name="dictionary">Dictionary to use</param>
        /// <returns>A value chosen at random</returns>
        /// <remarks>This seems like a longwinded process at first, but some roll tables have the same 
        /// values multiple times, so using the dictionary means we can have duplicate entries.</remarks>
        public static TEnum GetRandomValue<TEnum>(Dictionary<int, TEnum> dictionary) where TEnum : struct, IConvertible
        {
            var index = rng.NextFunction(1, dictionary.Count+1);
            return dictionary[index];
        }

        /// <summary>
        /// Gets a random mission type.
        /// </summary>
        /// <returns>a random mission type</returns>
        public static MissionType MissionType => GetRandomValue(EnumToDictionary<MissionType>());
        /// <summary>
        /// Gets a random civilized quality type.
        /// </summary>
        /// <returns></returns>
        public static LocationAndQualityType CivilizedQualityType => GetRandomValue(CivilizedQualityTypeLookupTable);
        /// <summary>
        /// Gets a random civilized location
        /// </summary>
        /// <returns>One of the first 20 items from the civilized quality type table.</returns>
        public static LocationAndQualityType CivilizedLocation => GetRandomValue(
                    CivilizedQualityTypeLookupTable.
                    Where(kvp => kvp.Key <= 20).
                    ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

        public static LocationAndQualityType WildernessLocation => GetRandomValue(
                    WildernessQualityTypeLookupTable.
                    Where(kvp => kvp.Key <= 20).
                    ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

        public static LocationAndQualityType Rationale => GetRandomValue(
                    CivilizedQualityTypeLookupTable.
                    Where(kvp => kvp.Key > 80).
                    ToDictionary(kvp => kvp.Key - 80, kvp => kvp.Value));

        private static Dictionary<int, LocationAndQualityType> LocationAndQualityTable
        {
            get
            {
                var lookupTable = EnumToDictionary<LocationAndQualityType>();

                return lookupTable;
            }
        }

        private static Dictionary<int, LocationAndQualityType> CivilizedQualityTypeLookupTable => 
            LocationAndQualityTable.
            Where(kvp => kvp.Key <= 100).
            ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        private static Dictionary<int, LocationAndQualityType> WildernessQualityTypeLookupTable =>
            LocationAndQualityTable.
            Where(kvp => kvp.Key > 100).
            ToDictionary(kvp => kvp.Key - 100, kvp => kvp.Value);
        public static PersonType PersonType => GetRandomValue(PersonTypeLookupTable);
        public static PersonType Foe => GetRandomValue(FoeLookupTable);

        public static Trait Trait => GetRandomValue(EnumToDictionary<Trait>());
        private static Dictionary<int, PersonType> PersonTypeLookupTable
        {
            get
            {
                var lookupTable = EnumToDictionary<PersonType>();
                return lookupTable;
            }
        }
        private static Dictionary<int, PersonType> FoeLookupTable =>
            PersonTypeLookupTable.
            Where(kvp => kvp.Key > 80).
            ToDictionary(kvp => kvp.Key - 80, kvp => kvp.Value);
            
        

        public static ItemType Item => GetRandomValue(ItemLookupTable);

        public static Dictionary<int, ItemType> ItemLookupTable
        {
            get
            {
                var lookupTable = EnumToDictionary<ItemType>();
                return lookupTable;
            }
        }

        public static CultureType CultureType => GetRandomValue(CultureTypeLookupTable);

        private static Dictionary<int, CultureType> CultureTypeLookupTable
        {
            get
            {
                var lookupTable = EnumToDictionary<CultureType>();
                return lookupTable;
            }
        }

        public static OccupationType OccupationType => GetRandomValue(OccupationTypeLookupTable);

        private static Dictionary<int, OccupationType> OccupationTypeLookupTable
        {
            get
            {
                var lookupTable = EnumToDictionary<OccupationType>();
                return lookupTable;
            }
        }
    }
}
