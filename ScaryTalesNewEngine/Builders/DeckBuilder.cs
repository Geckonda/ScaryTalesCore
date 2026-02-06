using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Builders
{
    public static class DeckBuilder
    {
        public static (DeckState, Dictionary<CardInstanceId, CardState>) Build(
            IReadOnlyDictionary<CardDefinitionId, CardDefinition> definitions)
        {
            var deck = new List<CardInstanceId>();
            var states = new Dictionary<CardInstanceId, CardState>();

            int instanceCounter = 0;

            foreach (var def in definitions.Values)
            {
                for (int i = 0; i < def.CardCountInDeck; i++)
                {
                    var instanceId = new CardInstanceId(instanceCounter++);

                    deck.Add(instanceId);

                    states[instanceId] = new CardState
                    {
                        InstanceId = instanceId,
                        DefinitionId = def.Id,
                        Position = def.DefaultPosition,
                        OwnerId = null
                    };
                }
            }

            return (
                new DeckState { Cards = deck },
                states
            );
        }
    }


}
