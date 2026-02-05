using ScaryTalesNewEngine.Defenitions;

namespace ScaryTalesNewEngine.Abstractions
{
    public interface ICardEffect
    {
        IEnumerable<IGameAction> CreateActions(GameContext context, PlayerId targetPlayerId);
    }
}
