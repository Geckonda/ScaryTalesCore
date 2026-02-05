using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Defenitions;

namespace ScaryTalesNewEngine
{
    public sealed class GameEngine
    {
        public GameContext Context { get; private set; }

        public GameEngine(GameContext initialContext)
        {
            Context = initialContext;
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

        public void ApplyCardEffect(ICardEffect effect, PlayerId targetPlayerId)
        {
            var actions = effect.CreateActions(Context, targetPlayerId);
            ApplyActions(actions);
        }
    }
}
