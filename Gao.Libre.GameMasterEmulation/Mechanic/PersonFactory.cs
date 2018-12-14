using System;
using System.Linq;
using Gao.Model.Libre;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    class PersonFactory
    {
        /// <summary>
        /// Generates a person.
        /// </summary>
        /// <returns></returns>
        internal static Person GeneratePerson(PersonType? type = null)
        {
            if (type == null) type = RandomTable.PersonType;
            var person = new Person { Type = type.Value};
            if (IsFoe(person.Type))
            {
                GenerateFoeDetails(person.Type, person);
            }
            person.Personality = RandomTable.Trait;
            return person;
        }

        internal static Person GenerateFoe()
        {
            return GeneratePerson(RandomTable.Foe);
        }

        private static void GenerateFoeDetails(PersonType type, Person person)
        {
            var foe = new Foe();
            var id = (int)type;
            switch(type)
            {
                case PersonType.WeakTeam:
                    foe.Quantity = Dice.Roll(1, 10).First();
                    foe.PointValue = Enumerable.Repeat(2, foe.Quantity).ToArray();
                    GenerateCultureAndOccupation(foe);
                    break;
                case PersonType.AverageTeam:
                    foe.Quantity = Dice.Roll(1, 10).First();
                    foe.PointValue = Enumerable.Repeat(3, foe.Quantity).ToArray();
                    GenerateCultureAndOccupation(foe);
                    break;
                case PersonType.AverageNonPlayerCharacter:
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 5 };
                    GenerateCultureAndOccupation(foe);
                    break;
                case PersonType.TalentedNonPlayerCharacter:
                case PersonType.AddLeader:
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 10 };
                    GenerateCultureAndOccupation(foe);
                    break;
                case PersonType.AnimalsMounts:
                case PersonType.VehiclesMounts:
                    foe.MinimumQuantity = 1;
                    foe.MaximumQuantity = Dice.Roll(1, 10).First();
                    foe.Quantity = (foe.MinimumQuantity.Value + foe.MaximumQuantity.Value)/2;
                    foe.MinimumPointValue = 2;
                    foe.PointValue = Enumerable.Repeat(foe.MinimumPointValue.Value, foe.Quantity).ToArray();
                    break;
                case PersonType.WeakMinions:
                case PersonType.WeakMindlessMinion:
                    foe.Quantity = Dice.Roll(1, 10).First();
                    foe.PointValue = Enumerable.Repeat(2, foe.Quantity).ToArray();
                    break;
                case PersonType.NonCombatant:
                    var bail = IsFoe(ReplacementFoeCheck(person));
                    if (bail) return;
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 1 };
                    break;
                case PersonType.AverageMinions:
                case PersonType.AverageMindlessMinion:
                    foe.Quantity = Dice.Roll(1, 10).First();
                    foe.PointValue = Enumerable.Repeat(3, foe.Quantity).ToArray();
                    break;
                case PersonType.BigBrute:
                case PersonType.PowerfulEntity:
                case PersonType.Automaton:
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 10 };
                    break;
                case PersonType.HybridsAnimals:
                    foe.MinimumQuantity = 1;
                    foe.MaximumQuantity = Dice.Roll(1, 10).First();
                    foe.Quantity = (foe.MinimumQuantity.Value + foe.MaximumQuantity.Value) / 2;
                    foe.PointValue = Enumerable.Repeat(5, foe.Quantity).ToArray();
                    break;
                case PersonType.SpecialAverageNonPlayerCharacter:
                    var newType = ReplacementFoeCheck(person);
                    if (IsFoe(newType)) return;
                    GenerateCultureAndOccupation(foe);
                    person.Type = newType;
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 5 };
                    break;
                case PersonType.SpecialTalentedNonPlayerCharacter:
                    newType = ReplacementFoeCheck(person);
                    if (IsFoe(newType)) return;
                    GenerateCultureAndOccupation(foe);
                    person.Type = newType;
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 10 };
                    break;
                case PersonType.Captives:
                    foe.IsCaptive = true;
                    foe.MinimumQuantity = 1;
                    foe.MaximumQuantity = Dice.Roll(1, 10).First();
                    foe.Quantity = (foe.MinimumQuantity.Value + foe.MaximumQuantity.Value) / 2;
                    foe.PointValue = Enumerable.Repeat(0, foe.Quantity).ToArray();
                    do
                    {
                        newType = RandomTable.PersonType;
                    } while (newType != PersonType.Captives);
                    person.Type = newType;
                    break;
                case PersonType.InfiltratorSpy:
                    foe.Quantity = 1;
                    foe.PointValue = new[] { 15 };
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));

            }
            person.FoeDetails = foe;

        }
        private static bool IsFoe(PersonType type) => (int)type > 80;

        private static PersonType ReplacementFoeCheck(Person person)
        {
            var newType = RandomTable.PersonType;
            var newTypeIsFoe = (int)newType > 80;
            if (newTypeIsFoe)
            {
                person.Type = newType;
                GenerateFoeDetails(newType, person);

            }

            return newType;
        }

        private static void GenerateCultureAndOccupation(Foe foe)
        {
            foe.Culture = RandomTable.CultureType;
            foe.Occupation = RandomTable.OccupationType;
        }
    }
}
