using ScaryTalesNewEngine.Defenitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryTalesNewEngine.States
{
    public sealed record BoardState
    (
        IReadOnlyList<CardInstanceId> CardsOnBoard,
        IReadOnlyList<CardInstanceId> DiscardPile,
        CardInstanceId? TimeOfDayCard
    );
}
