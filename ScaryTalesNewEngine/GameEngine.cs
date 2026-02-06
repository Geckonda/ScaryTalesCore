using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.Effects;

namespace ScaryTalesNewEngine
{
    public sealed class GameEngine
    {
        public GameContext Context { get; private set; }

        public GameEngine(GameContext initialContext)
        {
            Context = initialContext;
        }

        public void PlayCard(PlayerId player, CardInstanceId card)
        {
            var cardState = Context.CardStates[card];
            var definition = Context.CardDefinitions[cardState.DefinitionId];

            var effectContext = new EffectContext(
                context: Context,
                sourcePlayer: player,
                sourceCard: card
            );

            var actions = definition.Effect.BuildActions(effectContext);

            ApplyActions(actions);
        }
        public void ApplyAction(IGameAction action)
        {
            Context = action.Apply(Context);
        }

        public void ApplyActions(IEnumerable<IGameAction> actions)
        {
            foreach (var action in actions)
            {
                ApplyAction(action);
            }
        }
    }
}
