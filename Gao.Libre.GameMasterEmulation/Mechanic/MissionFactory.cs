using Gao.Model.Libre;

namespace Gao.Libre.GameMasterEmulation.Mechanic
{
    /// <summary>
    /// Generates Stories.
    /// </summary>
    public static class MissionFactory
    {
        public static Mission GenerateMission()
        {
            var returnValue = new Mission { Type = RandomTable.MissionType};
            GenerateTargetHints(returnValue.Type, returnValue);
            returnValue.Purpose = RandomTable.Rationale;
            //The first scene is always a cutscene.
            returnValue.Scenes.Add(new Scene { Type = SceneType.Cutscene });
            return returnValue;
        }

        public static Mission GenerateSideMission()
        {
            var returnValue = new Mission { Type = RandomTable.MissionType };
            GenerateTargetHints(returnValue.Type, returnValue);
            returnValue.Purpose = RandomTable.Rationale;
            return returnValue;
        }

        /// <summary>
        /// The mission type infers possible target hints.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="returnValue"></param>
        private static void GenerateTargetHints(MissionType type, Mission returnValue)
        {
            switch (type)
            {
                case MissionType.Attack:
                case MissionType.Escort:
                case MissionType.Investigate:
                case MissionType.Spy:
                    returnValue.Suggestions = new FocusSuggestion
                    {
                        CivilizedLocation = RandomTable.CivilizedLocation,
                        WildernessLocation = RandomTable.WildernessLocation,
                        Person = PersonFactory.GeneratePerson()
                    };
                    break;
                case MissionType.Capture:
                case MissionType.Escape:
                case MissionType.Evade:
                case MissionType.Hunt:
                case MissionType.Negotiate:
                case MissionType.Rescue:
                case MissionType.WinOver:
                    returnValue.Suggestions = new FocusSuggestion
                    {
                        Person = PersonFactory.GeneratePerson()
                    };
                    break;
                case MissionType.Defend:
                case MissionType.Explore:
                case MissionType.Patrol:
                case MissionType.Scout:
                case MissionType.Survive:
                    returnValue.Suggestions = new FocusSuggestion
                    {
                        CivilizedLocation = RandomTable.CivilizedLocation,
                        WildernessLocation = RandomTable.WildernessLocation
                    };
                    break;
                case MissionType.Deliver:
                case MissionType.FindRecover:
                case MissionType.Protect:
                    returnValue.Suggestions = new FocusSuggestion
                    {
                        Person = PersonFactory.GeneratePerson(),
                        Item = RandomTable.Item
                    };
                    break;
                case MissionType.Research:
                    returnValue.Suggestions = new FocusSuggestion
                    {
                        CivilizedLocation = RandomTable.CivilizedLocation,
                        WildernessLocation = RandomTable.WildernessLocation,
                        Person = PersonFactory.GeneratePerson(),
                        Item = RandomTable.Item
                    };
                    break;
                
            }
        }
    }
}
