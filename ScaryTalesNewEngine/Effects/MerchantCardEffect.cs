using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Actions.Cards;
using ScaryTalesNewEngine.Defenitions;

namespace ScaryTalesNewEngine.Effects
{
    /// <summary>
    /// Эффект карты "Купец": добрать 2 карты из колоды в руку целевого игрока.
    /// Состоит из двух атомарных DrawTopCardToHandAction.
    /// </summary>
    public sealed class MerchantCardEffect : ICardEffect
    {
        public IEnumerable<IGameAction> BuildActions(EffectContext context)
        {
            yield return new DrawTopCardToHandAction(context.SourcePlayer);
            yield return new DrawTopCardToHandAction(context.SourcePlayer);
        }
    }
}
