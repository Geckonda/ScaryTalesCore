namespace ScaryTalesNewEngine.Abstractions
{
    public interface IGameAction
    {
        GameContext Apply(GameContext context);
    }
}
