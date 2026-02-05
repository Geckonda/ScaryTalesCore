using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Defenitions;
using ScaryTalesNewEngine.Enums;
using ScaryTalesNewEngine.States;

namespace ScaryTalesNewEngine.Actions.Cards
{
    /// <summary>
    /// Атомарное действие: взять верхнюю карту из колоды и положить в руку игроку.
    /// </summary>
    public sealed class DrawTopCardToHandAction : IGameAction
    {
        private readonly PlayerId _playerId;

        public DrawTopCardToHandAction(PlayerId playerId)
        {
            _playerId = playerId;
        }

        public GameContext Apply(GameContext context)
        {
            if (context.DeckState.Cards.Count == 0)
            {
                return context;
            }

            if (!context.PlayerStates.TryGetValue(_playerId, out var playerState))
            {
                return context;
            }

            var drawnCardId = context.DeckState.Cards[0];
            var newDeckCards = context.DeckState.Cards.Skip(1).ToArray();

            var newDeckState = new DeckState
            {
                Cards = newDeckCards
            };

            var newHand = playerState.Hand.Append(drawnCardId).ToArray();
            var newPlayerState = new PlayerState
            {
                Id = playerState.Id,
                Score = playerState.Score,
                Hand = newHand,
                Items = playerState.Items
            };

            var updatedPlayerStates = new Dictionary<PlayerId, PlayerState>(context.PlayerStates)
            {
                [_playerId] = newPlayerState
            };

            var updatedCardStates = new Dictionary<CardId, CardState>(context.CardStates);
            if (updatedCardStates.TryGetValue(drawnCardId, out var existingCardState))
            {
                updatedCardStates[drawnCardId] = existingCardState with
                {
                    Position = CardPosition.InHand,
                    OwnerId = _playerId
                };
            }
            else
            {
                updatedCardStates[drawnCardId] = new CardState
                {
                    CardId = drawnCardId,
                    Position = CardPosition.InHand,
                    OwnerId = _playerId
                };
            }

            return context with
            {
                DeckState = newDeckState,
                PlayerStates = updatedPlayerStates,
                CardStates = updatedCardStates
            };
        }
    }
}
