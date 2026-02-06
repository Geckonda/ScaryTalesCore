using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Enums;

namespace ScaryTalesNewEngine.Defenitions
{
    public class CardDefinition
    {
        public CardDefinitionId Id { get; }
        public string Name { get; }
        public CardType Type { get; }
        public int Points { get; }
        public string EffectDescription { get; }
        public CardPosition DefaultPosition { get; }
        public int CardCountInDeck { get; }

        public ICardEffect Effect { get; }

        public CardDefinition(
            CardDefinitionId id,
            string name,
            CardType type,
            int points,
            string effectDescription,
            CardPosition defaultPosition,
            int cardCountInDeck,
            ICardEffect effect)
        {
            Id = id;
            Name = name;
            Type = type;
            Points = points;
            EffectDescription = effectDescription;
            DefaultPosition = defaultPosition;
            CardCountInDeck = cardCountInDeck;
            Effect = effect;
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }
    }
    public readonly record struct CardDefinitionId(int Value);
    public readonly record struct CardInstanceId(int Value);
}
