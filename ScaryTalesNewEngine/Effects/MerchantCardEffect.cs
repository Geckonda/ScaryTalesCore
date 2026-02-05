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
        public IEnumerable<IGameAction> CreateActions(GameContext context, PlayerId targetPlayerId)
        {
            return new IGameAction[]
            {
                new DrawTopCardToHandAction(targetPlayerId),
                new DrawTopCardToHandAction(targetPlayerId)
            };
        }
    }
}
