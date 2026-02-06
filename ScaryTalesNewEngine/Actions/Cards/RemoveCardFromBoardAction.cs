using ScaryTalesNewEngine.Abstractions;
using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.Actions.Cards
{
    public sealed class RemoveCardFromBoardAction : IGameAction
    {
        private readonly CardInstanceId _card;

        public RemoveCardFromBoardAction(CardInstanceId card)
        {
            _card = card;
        }

        public GameContext Apply(GameContext context)
        {
            var newBoardCards = context.BoardState.CardsOnBoard
                .Where(c => c != _card)
                .ToList();

            var newBoard = context.BoardState with
            {
                CardsOnBoard = newBoardCards
            };

            return context with { BoardState = newBoard };
        }
    }

}
