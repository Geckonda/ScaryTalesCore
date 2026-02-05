using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed class BoardState
    {
        public IReadOnlyList<CardId> CardsOnBoard { get; }
        public IReadOnlyList<CardId> DiscardPile { get; }
        public CardId? TimeOfDayCard { get; }
    }

}
