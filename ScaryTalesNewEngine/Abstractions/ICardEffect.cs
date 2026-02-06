using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.Effects;

namespace ScaryTalesNewEngine.Abstractions
{
    public interface ICardEffect
    {
        public IEnumerable<IGameAction> BuildActions(EffectContext context);
    }
}
